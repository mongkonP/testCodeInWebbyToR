using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0060__TextBlock
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddTextBlockintoaGrid.htm
    public partial  class frmAddTextBlockintoaGrid:Form
    {
        public frmAddTextBlockintoaGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddTextBlockintoaGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddTextBlockintoaGrid";
            this.Text = "frmAddTextBlockintoaGrid";
            this.Load += new System.EventHandler(this.frmAddTextBlockintoaGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmAddTextBlockintoaGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
