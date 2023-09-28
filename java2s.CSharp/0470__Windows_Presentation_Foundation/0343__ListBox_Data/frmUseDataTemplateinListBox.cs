using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0343__ListBox_Data
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseDataTemplateinListBox.htm
    public partial  class frmUseDataTemplateinListBox:Form
    {
        public frmUseDataTemplateinListBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseDataTemplateinListBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseDataTemplateinListBox";
            this.Text = "frmUseDataTemplateinListBox";
            this.Load += new System.EventHandler(this.frmUseDataTemplateinListBox_Load);
            this.ResumeLayout(false);

        }

        private void frmUseDataTemplateinListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
