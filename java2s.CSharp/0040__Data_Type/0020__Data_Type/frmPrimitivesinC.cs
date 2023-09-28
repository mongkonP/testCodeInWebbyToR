using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0020__Data_Type
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/PrimitivesinC.htm
    public partial  class frmPrimitivesinC:Form
    {
        public frmPrimitivesinC()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrimitivesinC
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrimitivesinC";
            this.Text = "frmPrimitivesinC";
            this.Load += new System.EventHandler(this.frmPrimitivesinC_Load);
            this.ResumeLayout(false);

        }

        private void frmPrimitivesinC_Load(object sender, EventArgs e)
        {

        }
    }
}
