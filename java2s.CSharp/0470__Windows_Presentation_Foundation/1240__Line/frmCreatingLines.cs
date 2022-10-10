using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1240__Line
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreatingLines.htm
    public partial  class frmCreatingLines:Form
    {
        public frmCreatingLines()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingLines
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingLines";
            this.Text = "frmCreatingLines";
            this.Load += new System.EventHandler(this.frmCreatingLines_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingLines_Load(object sender, EventArgs e)
        {

        }
    }
}
