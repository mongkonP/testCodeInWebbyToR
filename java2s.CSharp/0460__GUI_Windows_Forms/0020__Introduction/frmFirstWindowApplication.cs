using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0020__Introduction
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FirstWindowApplication.htm
    public partial  class frmFirstWindowApplication:Form
    {
        public frmFirstWindowApplication()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFirstWindowApplication
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFirstWindowApplication";
            this.Text = "frmFirstWindowApplication";
            this.Load += new System.EventHandler(this.frmFirstWindowApplication_Load);
            this.ResumeLayout(false);

        }

        private void frmFirstWindowApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
