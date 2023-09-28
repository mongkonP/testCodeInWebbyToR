using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0320__String_Pad_Trim
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/StringTrims.htm
    public partial  class frmStringTrims:Form
    {
        public frmStringTrims()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringTrims
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringTrims";
            this.Text = "frmStringTrims";
            this.Load += new System.EventHandler(this.frmStringTrims_Load);
            this.ResumeLayout(false);

        }

        private void frmStringTrims_Load(object sender, EventArgs e)
        {

        }
    }
}
