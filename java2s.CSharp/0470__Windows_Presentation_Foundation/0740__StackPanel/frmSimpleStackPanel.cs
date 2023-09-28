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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SimpleStackPanel.htm
    public partial  class frmSimpleStackPanel:Form
    {
        public frmSimpleStackPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleStackPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleStackPanel";
            this.Text = "frmSimpleStackPanel";
            this.Load += new System.EventHandler(this.frmSimpleStackPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleStackPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
