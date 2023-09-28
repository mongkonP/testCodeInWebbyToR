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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RotateaListBox.htm
    public partial  class frmRotateaListBox:Form
    {
        public frmRotateaListBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRotateaListBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRotateaListBox";
            this.Text = "frmRotateaListBox";
            this.Load += new System.EventHandler(this.frmRotateaListBox_Load);
            this.ResumeLayout(false);

        }

        private void frmRotateaListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
