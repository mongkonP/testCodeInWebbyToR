using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C1040__Nullable
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/NullableTypesAssignment.htm
    public partial  class frmNullableTypesAssignment:Form
    {
        public frmNullableTypesAssignment()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNullableTypesAssignment
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNullableTypesAssignment";
            this.Text = "frmNullableTypesAssignment";
            this.Load += new System.EventHandler(this.frmNullableTypesAssignment_Load);
            this.ResumeLayout(false);

        }

        private void frmNullableTypesAssignment_Load(object sender, EventArgs e)
        {

        }
    }
}
