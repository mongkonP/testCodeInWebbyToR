using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C1140__nullable
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/NullableTryParse.htm
    public partial  class frmNullableTryParse:Form
    {
        public frmNullableTryParse()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNullableTryParse
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNullableTryParse";
            this.Text = "frmNullableTryParse";
            this.Load += new System.EventHandler(this.frmNullableTryParse_Load);
            this.ResumeLayout(false);

        }

        private void frmNullableTryParse_Load(object sender, EventArgs e)
        {

        }
    }
}
