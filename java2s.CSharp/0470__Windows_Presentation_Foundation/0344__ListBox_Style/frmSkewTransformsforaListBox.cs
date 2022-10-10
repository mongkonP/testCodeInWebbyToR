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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SkewTransformsforaListBox.htm
    public partial  class frmSkewTransformsforaListBox:Form
    {
        public frmSkewTransformsforaListBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSkewTransformsforaListBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSkewTransformsforaListBox";
            this.Text = "frmSkewTransformsforaListBox";
            this.Load += new System.EventHandler(this.frmSkewTransformsforaListBox_Load);
            this.ResumeLayout(false);

        }

        private void frmSkewTransformsforaListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
