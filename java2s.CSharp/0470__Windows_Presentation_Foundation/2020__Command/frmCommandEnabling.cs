using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2020__Command
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CommandEnabling.htm
    public partial  class frmCommandEnabling:Form
    {
        public frmCommandEnabling()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCommandEnabling
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCommandEnabling";
            this.Text = "frmCommandEnabling";
            this.Load += new System.EventHandler(this.frmCommandEnabling_Load);
            this.ResumeLayout(false);

        }

        private void frmCommandEnabling_Load(object sender, EventArgs e)
        {

        }
    }
}
