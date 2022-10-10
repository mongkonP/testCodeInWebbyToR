using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0023__Button_Action
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnonymousdelegateasButtonAction.htm
    public partial  class frmAnonymousdelegateasButtonAction:Form
    {
        public frmAnonymousdelegateasButtonAction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnonymousdelegateasButtonAction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnonymousdelegateasButtonAction";
            this.Text = "frmAnonymousdelegateasButtonAction";
            this.Load += new System.EventHandler(this.frmAnonymousdelegateasButtonAction_Load);
            this.ResumeLayout(false);

        }

        private void frmAnonymousdelegateasButtonAction_Load(object sender, EventArgs e)
        {

        }
    }
}
