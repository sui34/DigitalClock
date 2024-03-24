using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class digitalClock : Form
    {
        public digitalClock()
        {
            InitializeComponent();
            // to remove the white border for btns
            redbtn.FlatStyle = FlatStyle.Flat;
            orangebtn.FlatStyle = FlatStyle.Flat;
            yellowbtn.FlatStyle = FlatStyle.Flat;
            greenbtn.FlatStyle = FlatStyle.Flat;
            cyanbtn.FlatStyle = FlatStyle.Flat;

            stylebtn.FlatStyle = FlatStyle.Flat;
            stylebtn2.FlatStyle = FlatStyle.Flat;
            stylebtn3.FlatStyle = FlatStyle.Flat;
        }

        private void digitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            //To update every single sec
            lblClock.Text = DateTime.Now.ToString("hh: mm : ss");
        }

        private void cyanbtn_Click(object sender, EventArgs e)
        {
            lblClock.ForeColor = Color.Cyan;
        }

        private void greenbtn_Click(object sender, EventArgs e)
        {
            lblClock.ForeColor= Color.Green;
        }

        private void yellowbtn_Click(object sender, EventArgs e)
        {
            lblClock.ForeColor = Color.Yellow;
        }

        private void orangebtn_Click(object sender, EventArgs e)
        {
            lblClock.ForeColor = Color.Orange;
        }

        private void redbtn_Click(object sender, EventArgs e)
        {
            lblClock.ForeColor = Color.Red;
        }

        private void stylebtn_Click(object sender, EventArgs e)
        {
            lblClock.Font = new Font("Impact", 48, FontStyle.Regular);
        }

        private void stylebtn2_Click(object sender, EventArgs e)
        {
            lblClock.Font = new Font("Lucida Handwriting", 48, FontStyle.Regular);
        }

        private void stylebtn3_Click(object sender, EventArgs e)
        {
            lblClock.Font = new Font("Algerian", 48, FontStyle.Regular);
        }
    }
}
