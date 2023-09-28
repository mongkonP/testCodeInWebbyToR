using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0344__ListBox_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ScaleaListBox.htm
    public partial  class frmScaleaListBox:Form
    {
        public frmScaleaListBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmScaleaListBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmScaleaListBox";
            this.Text = "frmScaleaListBox";
            this.Load += new System.EventHandler(this.frmScaleaListBox_Load);
            this.ResumeLayout(false);

        }

        private void frmScaleaListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
