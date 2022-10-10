using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0400__float_Point_Number
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/FloatingPointTypes.htm
    public partial  class frmFloatingPointTypes:Form
    {
        public frmFloatingPointTypes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFloatingPointTypes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFloatingPointTypes";
            this.Text = "frmFloatingPointTypes";
            this.Load += new System.EventHandler(this.frmFloatingPointTypes_Load);
            this.ResumeLayout(false);

        }

        private void frmFloatingPointTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
