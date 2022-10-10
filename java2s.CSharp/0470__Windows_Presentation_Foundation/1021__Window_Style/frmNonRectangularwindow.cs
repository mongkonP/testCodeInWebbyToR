using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1021__Window_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/NonRectangularwindow.htm
    public partial  class frmNonRectangularwindow:Form
    {
        public frmNonRectangularwindow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNonRectangularwindow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNonRectangularwindow";
            this.Text = "frmNonRectangularwindow";
            this.Load += new System.EventHandler(this.frmNonRectangularwindow_Load);
            this.ResumeLayout(false);

        }

        private void frmNonRectangularwindow_Load(object sender, EventArgs e)
        {

        }
    }
}
