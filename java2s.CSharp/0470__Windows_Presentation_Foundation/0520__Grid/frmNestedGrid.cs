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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/NestedGrid.htm
    public partial  class frmNestedGrid:Form
    {
        public frmNestedGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNestedGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNestedGrid";
            this.Text = "frmNestedGrid";
            this.Load += new System.EventHandler(this.frmNestedGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmNestedGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
