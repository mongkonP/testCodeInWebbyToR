using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0520__Grid
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WindowwithGrid.htm
    public partial  class frmWindowwithGrid:Form
    {
        public frmWindowwithGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWindowwithGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWindowwithGrid";
            this.Text = "frmWindowwithGrid";
            this.Load += new System.EventHandler(this.frmWindowwithGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmWindowwithGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
