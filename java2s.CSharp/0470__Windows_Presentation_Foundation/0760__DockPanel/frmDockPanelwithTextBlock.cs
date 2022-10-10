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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DockPanelwithTextBlock.htm
    public partial  class frmDockPanelwithTextBlock:Form
    {
        public frmDockPanelwithTextBlock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDockPanelwithTextBlock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDockPanelwithTextBlock";
            this.Text = "frmDockPanelwithTextBlock";
            this.Load += new System.EventHandler(this.frmDockPanelwithTextBlock_Load);
            this.ResumeLayout(false);

        }

        private void frmDockPanelwithTextBlock_Load(object sender, EventArgs e)
        {

        }
    }
}
