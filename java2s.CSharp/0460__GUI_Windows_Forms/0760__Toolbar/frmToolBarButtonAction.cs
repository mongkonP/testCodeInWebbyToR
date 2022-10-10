using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0760__Toolbar
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ToolBarButtonAction.htm
    public partial  class frmToolBarButtonAction:Form
    {
        public frmToolBarButtonAction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToolBarButtonAction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToolBarButtonAction";
            this.Text = "frmToolBarButtonAction";
            this.Load += new System.EventHandler(this.frmToolBarButtonAction_Load);
            this.ResumeLayout(false);

        }

        private void frmToolBarButtonAction_Load(object sender, EventArgs e)
        {

        }
    }
}
