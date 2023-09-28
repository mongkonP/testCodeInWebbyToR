using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0420__Printer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Displayallinstalledprintername.htm
    public partial  class frmDisplayallinstalledprintername:Form
    {
        public frmDisplayallinstalledprintername()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayallinstalledprintername
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayallinstalledprintername";
            this.Text = "frmDisplayallinstalledprintername";
            this.Load += new System.EventHandler(this.frmDisplayallinstalledprintername_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayallinstalledprintername_Load(object sender, EventArgs e)
        {

        }
    }
}
