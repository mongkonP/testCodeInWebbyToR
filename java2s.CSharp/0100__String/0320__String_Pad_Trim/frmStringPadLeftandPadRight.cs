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
    //http://www.java2s.com/Tutorial/CSharp/0100__String/StringPadLeftandPadRight.htm
    public partial  class frmStringPadLeftandPadRight:Form
    {
        public frmStringPadLeftandPadRight()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringPadLeftandPadRight
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringPadLeftandPadRight";
            this.Text = "frmStringPadLeftandPadRight";
            this.Load += new System.EventHandler(this.frmStringPadLeftandPadRight_Load);
            this.ResumeLayout(false);

        }

        private void frmStringPadLeftandPadRight_Load(object sender, EventArgs e)
        {

        }
    }
}
