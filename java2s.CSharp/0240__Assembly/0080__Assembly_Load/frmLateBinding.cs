using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0080__Assembly_Load
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/LateBinding.htm
    public partial  class frmLateBinding:Form
    {
        public frmLateBinding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLateBinding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLateBinding";
            this.Text = "frmLateBinding";
            this.Load += new System.EventHandler(this.frmLateBinding_Load);
            this.ResumeLayout(false);

        }

        private void frmLateBinding_Load(object sender, EventArgs e)
        {

        }
    }
}
