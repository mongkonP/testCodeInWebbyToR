using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2740__DrawingContext
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/OpenDrawingContextfromDrawingVisual.htm
    public partial  class frmOpenDrawingContextfromDrawingVisual:Form
    {
        public frmOpenDrawingContextfromDrawingVisual()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpenDrawingContextfromDrawingVisual
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpenDrawingContextfromDrawingVisual";
            this.Text = "frmOpenDrawingContextfromDrawingVisual";
            this.Load += new System.EventHandler(this.frmOpenDrawingContextfromDrawingVisual_Load);
            this.ResumeLayout(false);

        }

        private void frmOpenDrawingContextfromDrawingVisual_Load(object sender, EventArgs e)
        {

        }
    }
}
