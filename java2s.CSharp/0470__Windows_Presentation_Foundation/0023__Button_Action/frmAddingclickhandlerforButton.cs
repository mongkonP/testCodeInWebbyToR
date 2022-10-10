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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddingclickhandlerforButton.htm
    public partial  class frmAddingclickhandlerforButton:Form
    {
        public frmAddingclickhandlerforButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddingclickhandlerforButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddingclickhandlerforButton";
            this.Text = "frmAddingclickhandlerforButton";
            this.Load += new System.EventHandler(this.frmAddingclickhandlerforButton_Load);
            this.ResumeLayout(false);

        }

        private void frmAddingclickhandlerforButton_Load(object sender, EventArgs e)
        {

        }
    }
}
