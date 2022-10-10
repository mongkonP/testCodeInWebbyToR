using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0140__Join
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Useinjoin.htm
    public partial  class frmUseinjoin:Form
    {
        public frmUseinjoin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseinjoin
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseinjoin";
            this.Text = "frmUseinjoin";
            this.Load += new System.EventHandler(this.frmUseinjoin_Load);
            this.ResumeLayout(false);

        }

        private void frmUseinjoin_Load(object sender, EventArgs e)
        {

        }
    }
}
