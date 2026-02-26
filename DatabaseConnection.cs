using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare
{

    internal class DatabaseConnection
    {

        private static readonly string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        
        private static readonly string[] credentialFilePaths =
            { Path.Combine(userProfilePath + "\\OneDrive - Munster Technological University", "OraCredentials", "OraCredentialsHOME"),
              Path.Combine(userProfilePath + "\\OneDrive - Munster Technological University", "OraCredentials", "OraCredentialsMTU") };
        
        private string connectionString;

        internal DatabaseConnection()
        {
            string tempConnString = TryCredentials(credentialFilePaths);

            if (tempConnString.StartsWith("No valid file"))
            {
                Console.WriteLine(tempConnString);
                throw new InvalidOperationException(tempConnString);
            }

            SetConnectionString(tempConnString);
        }

        private void SetConnectionString(string connectionString) 
        {
            this.connectionString = connectionString;
        }
        
        private string TryCredentials(string[] credentialFilePaths)
        {
            foreach (var path in credentialFilePaths)
            {
                if (File.Exists(path))
                {
                    var tempConnString = File.ReadAllText(path);

                    try
                    {
                        using (var conn = new OracleConnection(tempConnString))
                        {
                            conn.Open();
                            return tempConnString;
                        }
                    }
                    catch (OracleException ex)
                    {
                        Console.WriteLine($"Oracle error: {ex.Message}");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine("Access denied. Try running the app with appropriate permissions.");
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine($"I/O error: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                    }
                }

            }
            return "No valid file or credentials was found";
        }

    }
}
