using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0320__ProcessStartInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/ProcessWindowStyleMaximized.htm
    public partial  class frmProcessWindowStyleMaximized:Form
    {
        public frmProcessWindowStyleMaximized()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProcessWindowStyleMaximized
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProcessWindowStyleMaximized";
            this.Text = "frmProcessWindowStyleMaximized";
            this.Load += new System.EventHandler(this.frmProcessWindowStyleMaximized_Load);
            this.ResumeLayout(false);

        }

        private void frmProcessWindowStyleMaximized_Load(object sender, EventArgs e)
        {

        }
    }
}
