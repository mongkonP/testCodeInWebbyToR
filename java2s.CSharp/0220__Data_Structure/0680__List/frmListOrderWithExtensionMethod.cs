using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0680__List
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ListOrderWithExtensionMethod.htm
    public partial  class frmListOrderWithExtensionMethod:Form
    {
        public frmListOrderWithExtensionMethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListOrderWithExtensionMethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListOrderWithExtensionMethod";
            this.Text = "frmListOrderWithExtensionMethod";
            this.Load += new System.EventHandler(this.frmListOrderWithExtensionMethod_Load);
            this.ResumeLayout(false);

        }

        private void frmListOrderWithExtensionMethod_Load(object sender, EventArgs e)
        {

        }
    }
}
