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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Lifetimeofavariable.htm
    public partial  class frmLifetimeofavariable:Form
    {
        public frmLifetimeofavariable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLifetimeofavariable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLifetimeofavariable";
            this.Text = "frmLifetimeofavariable";
            this.Load += new System.EventHandler(this.frmLifetimeofavariable_Load);
            this.ResumeLayout(false);

        }

        private void frmLifetimeofavariable_Load(object sender, EventArgs e)
        {

        }
    }
}
