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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/LookingforCommandLineOptions.htm
    public partial  class frmLookingforCommandLineOptions:Form
    {
        public frmLookingforCommandLineOptions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLookingforCommandLineOptions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLookingforCommandLineOptions";
            this.Text = "frmLookingforCommandLineOptions";
            this.Load += new System.EventHandler(this.frmLookingforCommandLineOptions_Load);
            this.ResumeLayout(false);

        }

        private void frmLookingforCommandLineOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
