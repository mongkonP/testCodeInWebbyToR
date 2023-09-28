using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0260__Array_CreateInstance
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Dynamicarraycreation.htm
    public partial  class frmDynamicarraycreation:Form
    {
        public frmDynamicarraycreation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDynamicarraycreation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDynamicarraycreation";
            this.Text = "frmDynamicarraycreation";
            this.Load += new System.EventHandler(this.frmDynamicarraycreation_Load);
            this.ResumeLayout(false);

        }

        private void frmDynamicarraycreation_Load(object sender, EventArgs e)
        {

        }
    }
}
