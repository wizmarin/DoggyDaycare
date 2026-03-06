using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoggyDaycare
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            try
            {
                dbConnection.OpenConnection();
                label1.Text = "Connection successful!";
            }
            catch (Exception ex)
            {
                label1.Text = "Connection failed: " + ex.Message;
            }

        }
    }
}
