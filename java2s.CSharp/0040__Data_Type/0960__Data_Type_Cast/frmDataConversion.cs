using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0960__Data_Type_Cast
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/DataConversion.htm
    public partial  class frmDataConversion:Form
    {
        public frmDataConversion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataConversion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataConversion";
            this.Text = "frmDataConversion";
            this.Load += new System.EventHandler(this.frmDataConversion_Load);
            this.ResumeLayout(false);

        }

        private void frmDataConversion_Load(object sender, EventArgs e)
        {

        }
    }
}
