using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1020__Print_PrintDocument
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/PrintBMPimage.htm
    public partial  class frmPrintBMPimage:Form
    {
        public frmPrintBMPimage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintBMPimage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintBMPimage";
            this.Text = "frmPrintBMPimage";
            this.Load += new System.EventHandler(this.frmPrintBMPimage_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintBMPimage_Load(object sender, EventArgs e)
        {

        }
    }
}
