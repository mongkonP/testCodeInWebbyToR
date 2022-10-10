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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/BitwiseANDofInteger.htm
    public partial  class frmBitwiseANDofInteger:Form
    {
        public frmBitwiseANDofInteger()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBitwiseANDofInteger
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBitwiseANDofInteger";
            this.Text = "frmBitwiseANDofInteger";
            this.Load += new System.EventHandler(this.frmBitwiseANDofInteger_Load);
            this.ResumeLayout(false);

        }

        private void frmBitwiseANDofInteger_Load(object sender, EventArgs e)
        {

        }
    }
}
