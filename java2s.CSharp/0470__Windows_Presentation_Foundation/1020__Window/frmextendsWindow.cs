using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1020__Window
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/extendsWindow.htm
    public partial  class frmextendsWindow:Form
    {
        public frmextendsWindow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmextendsWindow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmextendsWindow";
            this.Text = "frmextendsWindow";
            this.Load += new System.EventHandler(this.frmextendsWindow_Load);
            this.ResumeLayout(false);

        }

        private void frmextendsWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
