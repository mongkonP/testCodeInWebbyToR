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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PixelNotSnapped.htm
    public partial  class frmPixelNotSnapped:Form
    {
        public frmPixelNotSnapped()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPixelNotSnapped
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPixelNotSnapped";
            this.Text = "frmPixelNotSnapped";
            this.Load += new System.EventHandler(this.frmPixelNotSnapped_Load);
            this.ResumeLayout(false);

        }

        private void frmPixelNotSnapped_Load(object sender, EventArgs e)
        {

        }
    }
}
