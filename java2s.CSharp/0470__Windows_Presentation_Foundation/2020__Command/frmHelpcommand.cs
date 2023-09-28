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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Helpcommand.htm
    public partial  class frmHelpcommand:Form
    {
        public frmHelpcommand()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHelpcommand
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHelpcommand";
            this.Text = "frmHelpcommand";
            this.Load += new System.EventHandler(this.frmHelpcommand_Load);
            this.ResumeLayout(false);

        }

        private void frmHelpcommand_Load(object sender, EventArgs e)
        {

        }
    }
}
