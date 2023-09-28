using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0180__Goto
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Whilewithgotostatement.htm
    public partial  class frmWhilewithgotostatement:Form
    {
        public frmWhilewithgotostatement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWhilewithgotostatement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWhilewithgotostatement";
            this.Text = "frmWhilewithgotostatement";
            this.Load += new System.EventHandler(this.frmWhilewithgotostatement_Load);
            this.ResumeLayout(false);

        }

        private void frmWhilewithgotostatement_Load(object sender, EventArgs e)
        {

        }
    }
}
