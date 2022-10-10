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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/NullableStruct.htm
    public partial  class frmNullableStruct:Form
    {
        public frmNullableStruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNullableStruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNullableStruct";
            this.Text = "frmNullableStruct";
            this.Load += new System.EventHandler(this.frmNullableStruct_Load);
            this.ResumeLayout(false);

        }

        private void frmNullableStruct_Load(object sender, EventArgs e)
        {

        }
    }
}
