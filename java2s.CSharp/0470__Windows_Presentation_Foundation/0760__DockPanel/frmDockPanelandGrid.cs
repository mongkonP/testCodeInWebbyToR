using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0760__DockPanel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DockPanelandGrid.htm
    public partial  class frmDockPanelandGrid:Form
    {
        public frmDockPanelandGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDockPanelandGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDockPanelandGrid";
            this.Text = "frmDockPanelandGrid";
            this.Load += new System.EventHandler(this.frmDockPanelandGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmDockPanelandGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
