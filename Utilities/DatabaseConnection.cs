using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare.Utilities
{

    internal class DatabaseConnection
    {
        private System.Collections.Specialized.NameValueCollection appSettings = ConfigurationManager.AppSettings;
        private string _connectionString;
        private static DatabaseConnection? _instance;

        private DatabaseConnection()
        {
            var connectionString = TryCredentials();

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Failed to establish a database connection with any of the provided credentials.");
            }

            SetConnectionString(connectionString);
        }

        public static DatabaseConnection GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DatabaseConnection();
            }
            return _instance;
        }

        private void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }

        private string GetConnectionString()
        {
            string connectionString = _connectionString;
            return connectionString;
        }

        private string TryCredentials()
        {
            try
            {
                string? encryptedConnectionString = appSettings["Home_Server_Encrypted_Credentials"];
                var connectionString = Decryptor.Decrypt(encryptedConnectionString);

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                }

                return connectionString;
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Oracle error: {ex.Message}\nTrying another connection string.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                    string? encryptedConnectionString = appSettings["MTU_Server_Encrypted_Credentials"];
                    var connectionString = Decryptor.Decrypt(encryptedConnectionString);

                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        connection.Open();
                    }

                    return connectionString;
                }
                catch (OracleException ex2)
                {
                    MessageBox.Show($"Oracle error: {ex2.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
                catch (IOException)
                {
                    MessageBox.Show("I/O error occurred. Check logs for details.", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
                catch (Exception)
                {
                    MessageBox.Show("An unexpected error occurred. Check logs for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied. Try running the app with appropriate permissions.", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            catch (IOException)
            {
                MessageBox.Show("I/O error occurred. Check logs for details.", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error occurred. Check logs for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public OracleConnection OpenConnection()
        {
            string connectionString = GetConnectionString();
            OracleConnection connection = new OracleConnection(connectionString);
            connection.Open();
            return connection;
        }

        public DataSet ExecuteMultiRowQuery(string query)
        {
            OracleConnection conn = OpenConnection();

            OracleCommand cmd = new OracleCommand(query, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            
            DataSet ds = new DataSet();

            da.Fill(ds);

            conn.Close();

            return ds;
        }

        public OracleDataReader ExecuteSingleRowQuery(string query)
        {
            OracleConnection conn = OpenConnection();

            OracleCommand cmd = new OracleCommand(query, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            return dr;
        }

        public void ExecuteNonQuery(string query)
        {
            OracleConnection conn = OpenConnection();
            
            OracleCommand cmd = new OracleCommand(query, conn);
            
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}