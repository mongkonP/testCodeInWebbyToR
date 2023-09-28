using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0523__Grid_Operations
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddaRowDefinitiontoGrid.htm
    public partial  class frmAddaRowDefinitiontoGrid:Form
    {
        public frmAddaRowDefinitiontoGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddaRowDefinitiontoGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddaRowDefinitiontoGrid";
            this.Text = "frmAddaRowDefinitiontoGrid";
            this.Load += new System.EventHandler(this.frmAddaRowDefinitiontoGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmAddaRowDefinitiontoGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
