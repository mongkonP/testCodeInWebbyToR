using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0121__System
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/SystemdefinesthecoreoftheClibrary.htm
    public partial  class frmSystemdefinesthecoreoftheClibrary:Form
    {
        public frmSystemdefinesthecoreoftheClibrary()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSystemdefinesthecoreoftheClibrary
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSystemdefinesthecoreoftheClibrary";
            this.Text = "frmSystemdefinesthecoreoftheClibrary";
            this.Load += new System.EventHandler(this.frmSystemdefinesthecoreoftheClibrary_Load);
            this.ResumeLayout(false);

        }

        private void frmSystemdefinesthecoreoftheClibrary_Load(object sender, EventArgs e)
        {

        }
    }
}
