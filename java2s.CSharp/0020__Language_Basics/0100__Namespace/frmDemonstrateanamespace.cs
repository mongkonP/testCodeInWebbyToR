using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0100__Namespace
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Demonstrateanamespace.htm
    public partial  class frmDemonstrateanamespace:Form
    {
        public frmDemonstrateanamespace()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateanamespace
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateanamespace";
            this.Text = "frmDemonstrateanamespace";
            this.Load += new System.EventHandler(this.frmDemonstrateanamespace_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateanamespace_Load(object sender, EventArgs e)
        {

        }
    }
}
