using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0440__Border
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddingBordertoStackPanel.htm
    public partial  class frmAddingBordertoStackPanel:Form
    {
        public frmAddingBordertoStackPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddingBordertoStackPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddingBordertoStackPanel";
            this.Text = "frmAddingBordertoStackPanel";
            this.Load += new System.EventHandler(this.frmAddingBordertoStackPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmAddingBordertoStackPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
