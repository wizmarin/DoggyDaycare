using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Utilities
{

    internal class DatabaseConnection
    {
        private System.Collections.Specialized.NameValueCollection appSettings = ConfigurationManager.AppSettings;
        private string _connectionString;

        public DatabaseConnection()
        {
            var connectionString = TryCredentials();

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Failed to establish a database connection with any of the provided credentials.");
            }

            SetConnectionString(connectionString);
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

    }
}