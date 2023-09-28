using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0160__delegate_event
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/RetrievingEvenNumberedEventswiththeNETDelegateConvention.htm
    public partial  class frmRetrievingEvenNumberedEventswiththeNETDelegateConvention:Form
    {
        public frmRetrievingEvenNumberedEventswiththeNETDelegateConvention()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRetrievingEvenNumberedEventswiththeNETDelegateConvention
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRetrievingEvenNumberedEventswiththeNETDelegateConvention";
            this.Text = "frmRetrievingEvenNumberedEventswiththeNETDelegateConvention";
            this.Load += new System.EventHandler(this.frmRetrievingEvenNumberedEventswiththeNETDelegateConvention_Load);
            this.ResumeLayout(false);

        }

        private void frmRetrievingEvenNumberedEventswiththeNETDelegateConvention_Load(object sender, EventArgs e)
        {

        }
    }
}
