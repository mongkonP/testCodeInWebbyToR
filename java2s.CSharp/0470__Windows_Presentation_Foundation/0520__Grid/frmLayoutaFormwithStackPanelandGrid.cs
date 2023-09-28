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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LayoutaFormwithStackPanelandGrid.htm
    public partial  class frmLayoutaFormwithStackPanelandGrid:Form
    {
        public frmLayoutaFormwithStackPanelandGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLayoutaFormwithStackPanelandGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLayoutaFormwithStackPanelandGrid";
            this.Text = "frmLayoutaFormwithStackPanelandGrid";
            this.Load += new System.EventHandler(this.frmLayoutaFormwithStackPanelandGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmLayoutaFormwithStackPanelandGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
