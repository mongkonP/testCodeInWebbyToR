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
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Stringtrim.htm
    public partial  class frmStringtrim:Form
    {
        public frmStringtrim()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringtrim
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringtrim";
            this.Text = "frmStringtrim";
            this.Load += new System.EventHandler(this.frmStringtrim_Load);
            this.ResumeLayout(false);

        }

        private void frmStringtrim_Load(object sender, EventArgs e)
        {

        }
    }
}
