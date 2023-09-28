using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0900__Frame
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/XamlframeonaTab.htm
    public partial  class frmXamlframeonaTab:Form
    {
        public frmXamlframeonaTab()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXamlframeonaTab
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXamlframeonaTab";
            this.Text = "frmXamlframeonaTab";
            this.Load += new System.EventHandler(this.frmXamlframeonaTab_Load);
            this.ResumeLayout(false);

        }

        private void frmXamlframeonaTab_Load(object sender, EventArgs e)
        {

        }
    }
}
