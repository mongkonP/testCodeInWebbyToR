using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0760__DockPanel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DockPanelwithMenuToolBarTrayStatusBarStackPanel.htm
    public partial  class frmDockPanelwithMenuToolBarTrayStatusBarStackPanel:Form
    {
        public frmDockPanelwithMenuToolBarTrayStatusBarStackPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDockPanelwithMenuToolBarTrayStatusBarStackPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDockPanelwithMenuToolBarTrayStatusBarStackPanel";
            this.Text = "frmDockPanelwithMenuToolBarTrayStatusBarStackPanel";
            this.Load += new System.EventHandler(this.frmDockPanelwithMenuToolBarTrayStatusBarStackPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmDockPanelwithMenuToolBarTrayStatusBarStackPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
