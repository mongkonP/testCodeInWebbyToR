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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ArrangeUIElementsinaGrid.htm
    public partial  class frmArrangeUIElementsinaGrid:Form
    {
        public frmArrangeUIElementsinaGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArrangeUIElementsinaGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArrangeUIElementsinaGrid";
            this.Text = "frmArrangeUIElementsinaGrid";
            this.Load += new System.EventHandler(this.frmArrangeUIElementsinaGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmArrangeUIElementsinaGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
