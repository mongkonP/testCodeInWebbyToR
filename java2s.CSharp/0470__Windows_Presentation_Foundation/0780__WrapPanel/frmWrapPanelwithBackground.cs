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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WrapPanelwithBackground.htm
    public partial  class frmWrapPanelwithBackground:Form
    {
        public frmWrapPanelwithBackground()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWrapPanelwithBackground
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWrapPanelwithBackground";
            this.Text = "frmWrapPanelwithBackground";
            this.Load += new System.EventHandler(this.frmWrapPanelwithBackground_Load);
            this.ResumeLayout(false);

        }

        private void frmWrapPanelwithBackground_Load(object sender, EventArgs e)
        {

        }
    }
}
