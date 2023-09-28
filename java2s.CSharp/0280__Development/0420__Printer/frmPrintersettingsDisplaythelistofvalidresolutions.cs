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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/PrintersettingsDisplaythelistofvalidresolutions.htm
    public partial  class frmPrintersettingsDisplaythelistofvalidresolutions:Form
    {
        public frmPrintersettingsDisplaythelistofvalidresolutions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintersettingsDisplaythelistofvalidresolutions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintersettingsDisplaythelistofvalidresolutions";
            this.Text = "frmPrintersettingsDisplaythelistofvalidresolutions";
            this.Load += new System.EventHandler(this.frmPrintersettingsDisplaythelistofvalidresolutions_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintersettingsDisplaythelistofvalidresolutions_Load(object sender, EventArgs e)
        {

        }
    }
}
