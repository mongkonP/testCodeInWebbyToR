using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1240__Line
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DrawaGrid.htm
    public partial  class frmDrawaGrid:Form
    {
        public frmDrawaGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawaGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawaGrid";
            this.Text = "frmDrawaGrid";
            this.Load += new System.EventHandler(this.frmDrawaGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmDrawaGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
