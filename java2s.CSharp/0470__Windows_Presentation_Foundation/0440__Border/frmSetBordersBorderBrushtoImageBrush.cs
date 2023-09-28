using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0440__Border
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetBordersBorderBrushtoImageBrush.htm
    public partial  class frmSetBordersBorderBrushtoImageBrush:Form
    {
        public frmSetBordersBorderBrushtoImageBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetBordersBorderBrushtoImageBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetBordersBorderBrushtoImageBrush";
            this.Text = "frmSetBordersBorderBrushtoImageBrush";
            this.Load += new System.EventHandler(this.frmSetBordersBorderBrushtoImageBrush_Load);
            this.ResumeLayout(false);

        }

        private void frmSetBordersBorderBrushtoImageBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
