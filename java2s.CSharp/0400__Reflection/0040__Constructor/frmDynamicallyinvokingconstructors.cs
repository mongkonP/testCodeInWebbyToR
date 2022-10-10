using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0040__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Dynamicallyinvokingconstructors.htm
    public partial  class frmDynamicallyinvokingconstructors:Form
    {
        public frmDynamicallyinvokingconstructors()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDynamicallyinvokingconstructors
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDynamicallyinvokingconstructors";
            this.Text = "frmDynamicallyinvokingconstructors";
            this.Load += new System.EventHandler(this.frmDynamicallyinvokingconstructors_Load);
            this.ResumeLayout(false);

        }

        private void frmDynamicallyinvokingconstructors_Load(object sender, EventArgs e)
        {

        }
    }
}
