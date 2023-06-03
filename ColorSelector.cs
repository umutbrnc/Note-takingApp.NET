using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern_task_DT
{
    public partial class ColorSelector : Form
    {
        public ColorSelector()
        {
            InitializeComponent();
        }

        public String Redd {        
            get {  return  txtRed.Text; }
            set { txtRed.Text = value; } 
        }
        public String Greenn
        {
            get { return txtGreen.Text; }
            set { txtGreen.Text = value; }
        }
        public String Bluee
        {
            get { return txtBlue.Text; }
            set { txtBlue.Text = value; }
        }




        private void pbRgb_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pbRgb.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            txtRed.Text = clr.R.ToString();
            txtGreen.Text = clr.G.ToString();
            txtBlue.Text = clr.B.ToString();
            pnlSelected.BackColor = clr;
            

        }

        private void pbRgb_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pbRgb.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            lblScreen.BackColor = clr;
            lblRgbValues.Text = "R : " + clr.R.ToString() + "G : " + clr.G.ToString() + "B : " + clr.B.ToString();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

    }
}
