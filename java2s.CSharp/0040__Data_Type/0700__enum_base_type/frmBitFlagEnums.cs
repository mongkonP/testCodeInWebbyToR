using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0700__enum_base_type
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/BitFlagEnums.htm
    public partial  class frmBitFlagEnums:Form
    {
        public frmBitFlagEnums()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBitFlagEnums
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBitFlagEnums";
            this.Text = "frmBitFlagEnums";
            this.Load += new System.EventHandler(this.frmBitFlagEnums_Load);
            this.ResumeLayout(false);

        }

        private void frmBitFlagEnums_Load(object sender, EventArgs e)
        {

        }
    }
}
