using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoggyDaycare.Models;

namespace DoggyDaycare.Forms
{
    public partial class frmCheckIn : Form
    {
        private Booking booking;

        public frmCheckIn(Booking booking)
        {
            InitializeComponent();
            this.booking = booking;
        }

        private void frmCheckIn_Load(object sender, EventArgs e)
        {

        }
    }
}
