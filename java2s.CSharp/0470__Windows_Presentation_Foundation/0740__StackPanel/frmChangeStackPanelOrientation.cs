using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0740__StackPanel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ChangeStackPanelOrientation.htm
    public partial  class frmChangeStackPanelOrientation:Form
    {
        public frmChangeStackPanelOrientation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangeStackPanelOrientation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangeStackPanelOrientation";
            this.Text = "frmChangeStackPanelOrientation";
            this.Load += new System.EventHandler(this.frmChangeStackPanelOrientation_Load);
            this.ResumeLayout(false);

        }

        private void frmChangeStackPanelOrientation_Load(object sender, EventArgs e)
        {

        }
    }
}
