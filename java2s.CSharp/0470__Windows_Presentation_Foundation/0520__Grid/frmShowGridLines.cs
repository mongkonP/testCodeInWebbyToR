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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ShowGridLines.htm
    public partial  class frmShowGridLines:Form
    {
        public frmShowGridLines()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShowGridLines
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShowGridLines";
            this.Text = "frmShowGridLines";
            this.Load += new System.EventHandler(this.frmShowGridLines_Load);
            this.ResumeLayout(false);

        }

        private void frmShowGridLines_Load(object sender, EventArgs e)
        {

        }
    }
}
