using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0960__ToString
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/overrideToString.htm
    public partial  class frmoverrideToString:Form
    {
        public frmoverrideToString()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmoverrideToString
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmoverrideToString";
            this.Text = "frmoverrideToString";
            this.Load += new System.EventHandler(this.frmoverrideToString_Load);
            this.ResumeLayout(false);

        }

        private void frmoverrideToString_Load(object sender, EventArgs e)
        {

        }
    }
}
