using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0180__Variable_Scope
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/TheScopeandLifetimeofVariables.htm
    public partial  class frmTheScopeandLifetimeofVariables:Form
    {
        public frmTheScopeandLifetimeofVariables()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheScopeandLifetimeofVariables
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheScopeandLifetimeofVariables";
            this.Text = "frmTheScopeandLifetimeofVariables";
            this.Load += new System.EventHandler(this.frmTheScopeandLifetimeofVariables_Load);
            this.ResumeLayout(false);

        }

        private void frmTheScopeandLifetimeofVariables_Load(object sender, EventArgs e)
        {

        }
    }
}
