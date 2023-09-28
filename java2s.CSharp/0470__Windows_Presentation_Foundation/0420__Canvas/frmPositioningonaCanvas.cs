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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PositioningonaCanvas.htm
    public partial  class frmPositioningonaCanvas:Form
    {
        public frmPositioningonaCanvas()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPositioningonaCanvas
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPositioningonaCanvas";
            this.Text = "frmPositioningonaCanvas";
            this.Load += new System.EventHandler(this.frmPositioningonaCanvas_Load);
            this.ResumeLayout(false);

        }

        private void frmPositioningonaCanvas_Load(object sender, EventArgs e)
        {

        }
    }
}
