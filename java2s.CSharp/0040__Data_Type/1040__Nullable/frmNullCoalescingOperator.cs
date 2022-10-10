using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C1040__Nullable
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/NullCoalescingOperator.htm
    public partial  class frmNullCoalescingOperator:Form
    {
        public frmNullCoalescingOperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNullCoalescingOperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNullCoalescingOperator";
            this.Text = "frmNullCoalescingOperator";
            this.Load += new System.EventHandler(this.frmNullCoalescingOperator_Load);
            this.ResumeLayout(false);

        }

        private void frmNullCoalescingOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
