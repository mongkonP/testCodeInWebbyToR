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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/ulongMaxMinvalue.htm
    public partial  class frmulongMaxMinvalue:Form
    {
        public frmulongMaxMinvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmulongMaxMinvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmulongMaxMinvalue";
            this.Text = "frmulongMaxMinvalue";
            this.Load += new System.EventHandler(this.frmulongMaxMinvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmulongMaxMinvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
