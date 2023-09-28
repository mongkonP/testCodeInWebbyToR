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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/NestingStackPanel.htm
    public partial  class frmNestingStackPanel:Form
    {
        public frmNestingStackPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNestingStackPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNestingStackPanel";
            this.Text = "frmNestingStackPanel";
            this.Load += new System.EventHandler(this.frmNestingStackPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmNestingStackPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
