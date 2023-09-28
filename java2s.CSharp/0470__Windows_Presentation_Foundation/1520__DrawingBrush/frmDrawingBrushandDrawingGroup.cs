using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1520__DrawingBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DrawingBrushandDrawingGroup.htm
    public partial  class frmDrawingBrushandDrawingGroup:Form
    {
        public frmDrawingBrushandDrawingGroup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawingBrushandDrawingGroup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawingBrushandDrawingGroup";
            this.Text = "frmDrawingBrushandDrawingGroup";
            this.Load += new System.EventHandler(this.frmDrawingBrushandDrawingGroup_Load);
            this.ResumeLayout(false);

        }

        private void frmDrawingBrushandDrawingGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
