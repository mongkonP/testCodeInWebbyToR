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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/UsingforeachtoloopthroughtheparameterfromMainfunction.htm
    public partial  class frmUsingforeachtoloopthroughtheparameterfromMainfunction:Form
    {
        public frmUsingforeachtoloopthroughtheparameterfromMainfunction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingforeachtoloopthroughtheparameterfromMainfunction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingforeachtoloopthroughtheparameterfromMainfunction";
            this.Text = "frmUsingforeachtoloopthroughtheparameterfromMainfunction";
            this.Load += new System.EventHandler(this.frmUsingforeachtoloopthroughtheparameterfromMainfunction_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingforeachtoloopthroughtheparameterfromMainfunction_Load(object sender, EventArgs e)
        {

        }
    }
}
