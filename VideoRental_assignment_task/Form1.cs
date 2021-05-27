using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental_assignment_task
{
    public partial class Form1 : Form
    {
        int y =0, z = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            z++;
            if (z % 2 != 0)
            {
                lblText.Hide();
            }
            else {
                lblText.Show();
                z = 0;
            }
            if (y < 100)
            {
                y = y + 10;
                progressBar1.Value = y;
            }
            else {

                timer1.Stop();
                //here the code when the progressbar is filled then the new form will be visible and the old one hide
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }

        }
    }
}
