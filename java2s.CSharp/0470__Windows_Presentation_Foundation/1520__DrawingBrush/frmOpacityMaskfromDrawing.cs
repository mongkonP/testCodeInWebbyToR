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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/OpacityMaskfromDrawing.htm
    public partial  class frmOpacityMaskfromDrawing:Form
    {
        public frmOpacityMaskfromDrawing()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpacityMaskfromDrawing
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpacityMaskfromDrawing";
            this.Text = "frmOpacityMaskfromDrawing";
            this.Load += new System.EventHandler(this.frmOpacityMaskfromDrawing_Load);
            this.ResumeLayout(false);

        }

        private void frmOpacityMaskfromDrawing_Load(object sender, EventArgs e)
        {

        }
    }
}
