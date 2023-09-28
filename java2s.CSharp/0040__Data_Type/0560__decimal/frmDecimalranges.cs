using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0560__decimal
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Decimalranges.htm
    public partial  class frmDecimalranges:Form
    {
        public frmDecimalranges()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDecimalranges
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDecimalranges";
            this.Text = "frmDecimalranges";
            this.Load += new System.EventHandler(this.frmDecimalranges_Load);
            this.ResumeLayout(false);

        }

        private void frmDecimalranges_Load(object sender, EventArgs e)
        {

        }
    }
}
