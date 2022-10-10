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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/NullableClassMembers.htm
    public partial  class frmNullableClassMembers:Form
    {
        public frmNullableClassMembers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNullableClassMembers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNullableClassMembers";
            this.Text = "frmNullableClassMembers";
            this.Load += new System.EventHandler(this.frmNullableClassMembers_Load);
            this.ResumeLayout(false);

        }

        private void frmNullableClassMembers_Load(object sender, EventArgs e)
        {

        }
    }
}
