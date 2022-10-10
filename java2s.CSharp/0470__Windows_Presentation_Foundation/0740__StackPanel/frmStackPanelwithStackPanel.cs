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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/StackPanelwithStackPanel.htm
    public partial  class frmStackPanelwithStackPanel:Form
    {
        public frmStackPanelwithStackPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStackPanelwithStackPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStackPanelwithStackPanel";
            this.Text = "frmStackPanelwithStackPanel";
            this.Load += new System.EventHandler(this.frmStackPanelwithStackPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmStackPanelwithStackPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
