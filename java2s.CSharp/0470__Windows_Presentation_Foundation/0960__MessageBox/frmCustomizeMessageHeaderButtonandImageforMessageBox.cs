using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0960__MessageBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CustomizeMessageHeaderButtonandImageforMessageBox.htm
    public partial  class frmCustomizeMessageHeaderButtonandImageforMessageBox:Form
    {
        public frmCustomizeMessageHeaderButtonandImageforMessageBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCustomizeMessageHeaderButtonandImageforMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCustomizeMessageHeaderButtonandImageforMessageBox";
            this.Text = "frmCustomizeMessageHeaderButtonandImageforMessageBox";
            this.Load += new System.EventHandler(this.frmCustomizeMessageHeaderButtonandImageforMessageBox_Load);
            this.ResumeLayout(false);

        }

        private void frmCustomizeMessageHeaderButtonandImageforMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
