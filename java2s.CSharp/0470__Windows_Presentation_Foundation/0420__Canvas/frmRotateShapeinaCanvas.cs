using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0420__Canvas
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RotateShapeinaCanvas.htm
    public partial  class frmRotateShapeinaCanvas:Form
    {
        public frmRotateShapeinaCanvas()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRotateShapeinaCanvas
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRotateShapeinaCanvas";
            this.Text = "frmRotateShapeinaCanvas";
            this.Load += new System.EventHandler(this.frmRotateShapeinaCanvas_Load);
            this.ResumeLayout(false);

        }

        private void frmRotateShapeinaCanvas_Load(object sender, EventArgs e)
        {

        }
    }
}
