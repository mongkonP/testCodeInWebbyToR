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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/StatusBarandAutoScroll.htm
    public partial  class frmStatusBarandAutoScroll:Form
    {
        public frmStatusBarandAutoScroll()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStatusBarandAutoScroll
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStatusBarandAutoScroll";
            this.Text = "frmStatusBarandAutoScroll";
            this.Load += new System.EventHandler(this.frmStatusBarandAutoScroll_Load);
            this.ResumeLayout(false);

        }

        private void frmStatusBarandAutoScroll_Load(object sender, EventArgs e)
        {

        }
    }
}
