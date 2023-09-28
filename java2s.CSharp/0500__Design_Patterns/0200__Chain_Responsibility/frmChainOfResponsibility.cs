using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0200__Chain_Responsibility
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/ChainOfResponsibility.htm
    public partial  class frmChainOfResponsibility:Form
    {
        public frmChainOfResponsibility()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChainOfResponsibility
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChainOfResponsibility";
            this.Text = "frmChainOfResponsibility";
            this.Load += new System.EventHandler(this.frmChainOfResponsibility_Load);
            this.ResumeLayout(false);

        }

        private void frmChainOfResponsibility_Load(object sender, EventArgs e)
        {

        }
    }
}
