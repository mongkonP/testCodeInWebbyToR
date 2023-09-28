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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Overridewithoutoverridekeyword.htm
    public partial  class frmOverridewithoutoverridekeyword:Form
    {
        public frmOverridewithoutoverridekeyword()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverridewithoutoverridekeyword
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverridewithoutoverridekeyword";
            this.Text = "frmOverridewithoutoverridekeyword";
            this.Load += new System.EventHandler(this.frmOverridewithoutoverridekeyword_Load);
            this.ResumeLayout(false);

        }

        private void frmOverridewithoutoverridekeyword_Load(object sender, EventArgs e)
        {

        }
    }
}
