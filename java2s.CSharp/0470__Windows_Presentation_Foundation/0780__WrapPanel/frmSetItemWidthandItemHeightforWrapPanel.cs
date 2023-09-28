using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0780__WrapPanel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetItemWidthandItemHeightforWrapPanel.htm
    public partial  class frmSetItemWidthandItemHeightforWrapPanel:Form
    {
        public frmSetItemWidthandItemHeightforWrapPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetItemWidthandItemHeightforWrapPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetItemWidthandItemHeightforWrapPanel";
            this.Text = "frmSetItemWidthandItemHeightforWrapPanel";
            this.Load += new System.EventHandler(this.frmSetItemWidthandItemHeightforWrapPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmSetItemWidthandItemHeightforWrapPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
