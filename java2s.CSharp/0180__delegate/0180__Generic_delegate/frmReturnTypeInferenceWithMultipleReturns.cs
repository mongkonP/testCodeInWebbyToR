using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0180__Generic_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/ReturnTypeInferenceWithMultipleReturns.htm
    public partial  class frmReturnTypeInferenceWithMultipleReturns:Form
    {
        public frmReturnTypeInferenceWithMultipleReturns()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReturnTypeInferenceWithMultipleReturns
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReturnTypeInferenceWithMultipleReturns";
            this.Text = "frmReturnTypeInferenceWithMultipleReturns";
            this.Load += new System.EventHandler(this.frmReturnTypeInferenceWithMultipleReturns_Load);
            this.ResumeLayout(false);

        }

        private void frmReturnTypeInferenceWithMultipleReturns_Load(object sender, EventArgs e)
        {

        }
    }
}
