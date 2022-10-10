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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddaColumnDefinitiontoGrid.htm
    public partial  class frmAddaColumnDefinitiontoGrid:Form
    {
        public frmAddaColumnDefinitiontoGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddaColumnDefinitiontoGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddaColumnDefinitiontoGrid";
            this.Text = "frmAddaColumnDefinitiontoGrid";
            this.Load += new System.EventHandler(this.frmAddaColumnDefinitiontoGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmAddaColumnDefinitiontoGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
