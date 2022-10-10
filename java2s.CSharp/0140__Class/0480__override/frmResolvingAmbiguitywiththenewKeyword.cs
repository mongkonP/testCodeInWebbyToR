using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0480__override
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ResolvingAmbiguitywiththenewKeyword.htm
    public partial  class frmResolvingAmbiguitywiththenewKeyword:Form
    {
        public frmResolvingAmbiguitywiththenewKeyword()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmResolvingAmbiguitywiththenewKeyword
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmResolvingAmbiguitywiththenewKeyword";
            this.Text = "frmResolvingAmbiguitywiththenewKeyword";
            this.Load += new System.EventHandler(this.frmResolvingAmbiguitywiththenewKeyword_Load);
            this.ResumeLayout(false);

        }

        private void frmResolvingAmbiguitywiththenewKeyword_Load(object sender, EventArgs e)
        {

        }
    }
}
