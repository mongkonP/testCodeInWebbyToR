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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DateandTimeinStatusBar.htm
    public partial  class frmDateandTimeinStatusBar:Form
    {
        public frmDateandTimeinStatusBar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDateandTimeinStatusBar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDateandTimeinStatusBar";
            this.Text = "frmDateandTimeinStatusBar";
            this.Load += new System.EventHandler(this.frmDateandTimeinStatusBar_Load);
            this.ResumeLayout(false);

        }

        private void frmDateandTimeinStatusBar_Load(object sender, EventArgs e)
        {

        }
    }
}
