using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0880__MessageBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SimplestMessageBox.htm
    public partial  class frmSimplestMessageBox:Form
    {
        public frmSimplestMessageBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimplestMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimplestMessageBox";
            this.Text = "frmSimplestMessageBox";
            this.Load += new System.EventHandler(this.frmSimplestMessageBox_Load);
            this.ResumeLayout(false);

        }

        private void frmSimplestMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
