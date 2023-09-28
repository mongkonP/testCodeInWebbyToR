using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0120__int_Calculation
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/OverflowinganIntegerValue.htm
    public partial  class frmOverflowinganIntegerValue:Form
    {
        public frmOverflowinganIntegerValue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverflowinganIntegerValue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverflowinganIntegerValue";
            this.Text = "frmOverflowinganIntegerValue";
            this.Load += new System.EventHandler(this.frmOverflowinganIntegerValue_Load);
            this.ResumeLayout(false);

        }

        private void frmOverflowinganIntegerValue_Load(object sender, EventArgs e)
        {

        }
    }
}
