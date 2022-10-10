using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0400__StringBuilder
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/DisplaythecontentsofStringBuilder.htm
    public partial  class frmDisplaythecontentsofStringBuilder:Form
    {
        public frmDisplaythecontentsofStringBuilder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaythecontentsofStringBuilder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaythecontentsofStringBuilder";
            this.Text = "frmDisplaythecontentsofStringBuilder";
            this.Load += new System.EventHandler(this.frmDisplaythecontentsofStringBuilder_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaythecontentsofStringBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
