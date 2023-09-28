using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0560__UniformGrid
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TheUniformGrid.htm
    public partial  class frmTheUniformGrid:Form
    {
        public frmTheUniformGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheUniformGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheUniformGrid";
            this.Text = "frmTheUniformGrid";
            this.Load += new System.EventHandler(this.frmTheUniformGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmTheUniformGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
