using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0280__destructor
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Demonstrateadestructor.htm
    public partial  class frmDemonstrateadestructor:Form
    {
        public frmDemonstrateadestructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateadestructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateadestructor";
            this.Text = "frmDemonstrateadestructor";
            this.Load += new System.EventHandler(this.frmDemonstrateadestructor_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateadestructor_Load(object sender, EventArgs e)
        {

        }
    }
}
