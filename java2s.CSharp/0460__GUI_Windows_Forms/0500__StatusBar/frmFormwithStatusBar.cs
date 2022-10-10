using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0500__StatusBar
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FormwithStatusBar.htm
    public partial  class frmFormwithStatusBar:Form
    {
        public frmFormwithStatusBar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormwithStatusBar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormwithStatusBar";
            this.Text = "frmFormwithStatusBar";
            this.Load += new System.EventHandler(this.frmFormwithStatusBar_Load);
            this.ResumeLayout(false);

        }

        private void frmFormwithStatusBar_Load(object sender, EventArgs e)
        {

        }
    }
}
