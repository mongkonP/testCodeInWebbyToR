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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Canvasdependant.htm
    public partial  class frmCanvasdependant:Form
    {
        public frmCanvasdependant()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCanvasdependant
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCanvasdependant";
            this.Text = "frmCanvasdependant";
            this.Load += new System.EventHandler(this.frmCanvasdependant_Load);
            this.ResumeLayout(false);

        }

        private void frmCanvasdependant_Load(object sender, EventArgs e)
        {

        }
    }
}
