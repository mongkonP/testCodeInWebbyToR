using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0480__Separator
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddSeparatortoStackPanel.htm
    public partial  class frmAddSeparatortoStackPanel:Form
    {
        public frmAddSeparatortoStackPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddSeparatortoStackPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddSeparatortoStackPanel";
            this.Text = "frmAddSeparatortoStackPanel";
            this.Load += new System.EventHandler(this.frmAddSeparatortoStackPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmAddSeparatortoStackPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
