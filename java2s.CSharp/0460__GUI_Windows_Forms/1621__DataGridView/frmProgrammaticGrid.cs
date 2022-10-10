using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1621__DataGridView
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ProgrammaticGrid.htm
    public partial  class frmProgrammaticGrid:Form
    {
        public frmProgrammaticGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProgrammaticGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProgrammaticGrid";
            this.Text = "frmProgrammaticGrid";
            this.Load += new System.EventHandler(this.frmProgrammaticGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmProgrammaticGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
