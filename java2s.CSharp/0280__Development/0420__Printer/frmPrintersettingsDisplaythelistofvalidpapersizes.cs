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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/PrintersettingsDisplaythelistofvalidpapersizes.htm
    public partial  class frmPrintersettingsDisplaythelistofvalidpapersizes:Form
    {
        public frmPrintersettingsDisplaythelistofvalidpapersizes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintersettingsDisplaythelistofvalidpapersizes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintersettingsDisplaythelistofvalidpapersizes";
            this.Text = "frmPrintersettingsDisplaythelistofvalidpapersizes";
            this.Load += new System.EventHandler(this.frmPrintersettingsDisplaythelistofvalidpapersizes_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintersettingsDisplaythelistofvalidpapersizes_Load(object sender, EventArgs e)
        {

        }
    }
}
