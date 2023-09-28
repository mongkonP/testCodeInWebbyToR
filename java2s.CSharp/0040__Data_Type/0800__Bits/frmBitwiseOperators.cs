using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0800__Bits
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/BitwiseOperators.htm
    public partial  class frmBitwiseOperators:Form
    {
        public frmBitwiseOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBitwiseOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBitwiseOperators";
            this.Text = "frmBitwiseOperators";
            this.Load += new System.EventHandler(this.frmBitwiseOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmBitwiseOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
