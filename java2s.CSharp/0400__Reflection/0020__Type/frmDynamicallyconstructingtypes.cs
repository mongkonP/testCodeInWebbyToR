using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0020__Type
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Dynamicallyconstructingtypes.htm
    public partial  class frmDynamicallyconstructingtypes:Form
    {
        public frmDynamicallyconstructingtypes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDynamicallyconstructingtypes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDynamicallyconstructingtypes";
            this.Text = "frmDynamicallyconstructingtypes";
            this.Load += new System.EventHandler(this.frmDynamicallyconstructingtypes_Load);
            this.ResumeLayout(false);

        }

        private void frmDynamicallyconstructingtypes_Load(object sender, EventArgs e)
        {

        }
    }
}
