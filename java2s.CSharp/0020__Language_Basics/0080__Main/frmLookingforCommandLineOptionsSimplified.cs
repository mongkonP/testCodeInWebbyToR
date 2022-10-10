using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0080__Main
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/LookingforCommandLineOptionsSimplified.htm
    public partial  class frmLookingforCommandLineOptionsSimplified:Form
    {
        public frmLookingforCommandLineOptionsSimplified()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLookingforCommandLineOptionsSimplified
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLookingforCommandLineOptionsSimplified";
            this.Text = "frmLookingforCommandLineOptionsSimplified";
            this.Load += new System.EventHandler(this.frmLookingforCommandLineOptionsSimplified_Load);
            this.ResumeLayout(false);

        }

        private void frmLookingforCommandLineOptionsSimplified_Load(object sender, EventArgs e)
        {

        }
    }
}
