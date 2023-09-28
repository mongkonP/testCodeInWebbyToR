using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0521__Grid_Row_Column
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SplitGrid.htm
    public partial  class frmSplitGrid:Form
    {
        public frmSplitGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSplitGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSplitGrid";
            this.Text = "frmSplitGrid";
            this.Load += new System.EventHandler(this.frmSplitGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmSplitGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
