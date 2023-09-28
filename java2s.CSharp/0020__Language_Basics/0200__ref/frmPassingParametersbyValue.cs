using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0200__ref
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/PassingParametersbyValue.htm
    public partial  class frmPassingParametersbyValue:Form
    {
        public frmPassingParametersbyValue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPassingParametersbyValue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPassingParametersbyValue";
            this.Text = "frmPassingParametersbyValue";
            this.Load += new System.EventHandler(this.frmPassingParametersbyValue_Load);
            this.ResumeLayout(false);

        }

        private void frmPassingParametersbyValue_Load(object sender, EventArgs e)
        {

        }
    }
}
