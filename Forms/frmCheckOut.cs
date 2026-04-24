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
    public partial class frmCheckOut : Form
    {
        private Booking booking;

        public frmCheckOut(Booking booking)
        {
            InitializeComponent();
            this.booking = booking;
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {

        }
    }
}
