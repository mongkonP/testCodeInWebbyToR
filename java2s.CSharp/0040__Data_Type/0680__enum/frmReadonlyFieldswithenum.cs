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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/ReadonlyFieldswithenum.htm
    public partial  class frmReadonlyFieldswithenum:Form
    {
        public frmReadonlyFieldswithenum()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadonlyFieldswithenum
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadonlyFieldswithenum";
            this.Text = "frmReadonlyFieldswithenum";
            this.Load += new System.EventHandler(this.frmReadonlyFieldswithenum_Load);
            this.ResumeLayout(false);

        }

        private void frmReadonlyFieldswithenum_Load(object sender, EventArgs e)
        {

        }
    }
}
