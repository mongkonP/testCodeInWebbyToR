using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1460__VisualBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/VisualBrushForaRectangle.htm
    public partial  class frmVisualBrushForaRectangle:Form
    {
        public frmVisualBrushForaRectangle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVisualBrushForaRectangle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVisualBrushForaRectangle";
            this.Text = "frmVisualBrushForaRectangle";
            this.Load += new System.EventHandler(this.frmVisualBrushForaRectangle_Load);
            this.ResumeLayout(false);

        }

        private void frmVisualBrushForaRectangle_Load(object sender, EventArgs e)
        {

        }
    }
}
