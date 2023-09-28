using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0760__enums_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/DefineEnums.htm
    public partial  class frmDefineEnums:Form
    {
        public frmDefineEnums()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefineEnums
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefineEnums";
            this.Text = "frmDefineEnums";
            this.Load += new System.EventHandler(this.frmDefineEnums_Load);
            this.ResumeLayout(false);

        }

        private void frmDefineEnums_Load(object sender, EventArgs e)
        {

        }
    }
}
