using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0680__enum
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Printoutthedetailsofanyenum.htm
    public partial  class frmPrintoutthedetailsofanyenum:Form
    {
        public frmPrintoutthedetailsofanyenum()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintoutthedetailsofanyenum
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintoutthedetailsofanyenum";
            this.Text = "frmPrintoutthedetailsofanyenum";
            this.Load += new System.EventHandler(this.frmPrintoutthedetailsofanyenum_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintoutthedetailsofanyenum_Load(object sender, EventArgs e)
        {

        }
    }
}
