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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Illustratesadestructor.htm
    public partial  class frmIllustratesadestructor:Form
    {
        public frmIllustratesadestructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIllustratesadestructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIllustratesadestructor";
            this.Text = "frmIllustratesadestructor";
            this.Load += new System.EventHandler(this.frmIllustratesadestructor_Load);
            this.ResumeLayout(false);

        }

        private void frmIllustratesadestructor_Load(object sender, EventArgs e)
        {

        }
    }
}
