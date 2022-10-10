using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0300__byte_overflow
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/byteoverflowwithunchecked.htm
    public partial  class frmbyteoverflowwithunchecked:Form
    {
        public frmbyteoverflowwithunchecked()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmbyteoverflowwithunchecked
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmbyteoverflowwithunchecked";
            this.Text = "frmbyteoverflowwithunchecked";
            this.Load += new System.EventHandler(this.frmbyteoverflowwithunchecked_Load);
            this.ResumeLayout(false);

        }

        private void frmbyteoverflowwithunchecked_Load(object sender, EventArgs e)
        {

        }
    }
}
