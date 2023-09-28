using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1340__Skip
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UseSkip.htm
    public partial  class frmUseSkip:Form
    {
        public frmUseSkip()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseSkip
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseSkip";
            this.Text = "frmUseSkip";
            this.Load += new System.EventHandler(this.frmUseSkip_Load);
            this.ResumeLayout(false);

        }

        private void frmUseSkip_Load(object sender, EventArgs e)
        {

        }
    }
}
