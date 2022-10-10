using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C1120__IFormattable
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/FormattableVector.htm
    public partial  class frmFormattableVector:Form
    {
        public frmFormattableVector()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormattableVector
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormattableVector";
            this.Text = "frmFormattableVector";
            this.Load += new System.EventHandler(this.frmFormattableVector_Load);
            this.ResumeLayout(false);

        }

        private void frmFormattableVector_Load(object sender, EventArgs e)
        {

        }
    }
}
