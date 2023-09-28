using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0540__BitArray
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/BitArrayXor.htm
    public partial  class frmBitArrayXor:Form
    {
        public frmBitArrayXor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBitArrayXor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBitArrayXor";
            this.Text = "frmBitArrayXor";
            this.Load += new System.EventHandler(this.frmBitArrayXor_Load);
            this.ResumeLayout(false);

        }

        private void frmBitArrayXor_Load(object sender, EventArgs e)
        {

        }
    }
}
