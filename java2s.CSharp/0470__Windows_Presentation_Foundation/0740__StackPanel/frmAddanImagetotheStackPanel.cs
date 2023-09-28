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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddanImagetotheStackPanel.htm
    public partial  class frmAddanImagetotheStackPanel:Form
    {
        public frmAddanImagetotheStackPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddanImagetotheStackPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddanImagetotheStackPanel";
            this.Text = "frmAddanImagetotheStackPanel";
            this.Load += new System.EventHandler(this.frmAddanImagetotheStackPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmAddanImagetotheStackPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
