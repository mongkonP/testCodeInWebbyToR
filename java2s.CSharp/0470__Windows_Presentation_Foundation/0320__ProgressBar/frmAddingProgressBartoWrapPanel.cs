using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0320__ProgressBar
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddingProgressBartoWrapPanel.htm
    public partial  class frmAddingProgressBartoWrapPanel:Form
    {
        public frmAddingProgressBartoWrapPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddingProgressBartoWrapPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddingProgressBartoWrapPanel";
            this.Text = "frmAddingProgressBartoWrapPanel";
            this.Load += new System.EventHandler(this.frmAddingProgressBartoWrapPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmAddingProgressBartoWrapPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
