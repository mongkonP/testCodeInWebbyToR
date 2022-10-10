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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DefinerowscolumnsforGrid.htm
    public partial  class frmDefinerowscolumnsforGrid:Form
    {
        public frmDefinerowscolumnsforGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefinerowscolumnsforGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefinerowscolumnsforGrid";
            this.Text = "frmDefinerowscolumnsforGrid";
            this.Load += new System.EventHandler(this.frmDefinerowscolumnsforGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmDefinerowscolumnsforGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
