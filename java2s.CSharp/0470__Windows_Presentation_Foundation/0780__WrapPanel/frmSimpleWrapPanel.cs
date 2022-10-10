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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SimpleWrapPanel.htm
    public partial  class frmSimpleWrapPanel:Form
    {
        public frmSimpleWrapPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleWrapPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleWrapPanel";
            this.Text = "frmSimpleWrapPanel";
            this.Load += new System.EventHandler(this.frmSimpleWrapPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleWrapPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
