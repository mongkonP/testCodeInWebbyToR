using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C1060__IDisposable_with_using
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Disposeiscalledautomaticallywhentheusingblockexits.htm
    public partial  class frmDisposeiscalledautomaticallywhentheusingblockexits:Form
    {
        public frmDisposeiscalledautomaticallywhentheusingblockexits()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisposeiscalledautomaticallywhentheusingblockexits
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisposeiscalledautomaticallywhentheusingblockexits";
            this.Text = "frmDisposeiscalledautomaticallywhentheusingblockexits";
            this.Load += new System.EventHandler(this.frmDisposeiscalledautomaticallywhentheusingblockexits_Load);
            this.ResumeLayout(false);

        }

        private void frmDisposeiscalledautomaticallywhentheusingblockexits_Load(object sender, EventArgs e)
        {

        }
    }
}
