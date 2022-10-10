using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0600__ToolBar
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ToolBarButtonStyleKey.htm
    public partial  class frmToolBarButtonStyleKey:Form
    {
        public frmToolBarButtonStyleKey()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToolBarButtonStyleKey
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToolBarButtonStyleKey";
            this.Text = "frmToolBarButtonStyleKey";
            this.Load += new System.EventHandler(this.frmToolBarButtonStyleKey_Load);
            this.ResumeLayout(false);

        }

        private void frmToolBarButtonStyleKey_Load(object sender, EventArgs e)
        {

        }
    }
}
