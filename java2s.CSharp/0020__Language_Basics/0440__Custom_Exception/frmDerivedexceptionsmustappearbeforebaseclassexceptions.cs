using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0440__Custom_Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Derivedexceptionsmustappearbeforebaseclassexceptions.htm
    public partial  class frmDerivedexceptionsmustappearbeforebaseclassexceptions:Form
    {
        public frmDerivedexceptionsmustappearbeforebaseclassexceptions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDerivedexceptionsmustappearbeforebaseclassexceptions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDerivedexceptionsmustappearbeforebaseclassexceptions";
            this.Text = "frmDerivedexceptionsmustappearbeforebaseclassexceptions";
            this.Load += new System.EventHandler(this.frmDerivedexceptionsmustappearbeforebaseclassexceptions_Load);
            this.ResumeLayout(false);

        }

        private void frmDerivedexceptionsmustappearbeforebaseclassexceptions_Load(object sender, EventArgs e)
        {

        }
    }
}
