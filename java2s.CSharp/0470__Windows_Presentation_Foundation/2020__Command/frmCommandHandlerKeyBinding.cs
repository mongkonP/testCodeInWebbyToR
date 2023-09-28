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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CommandHandlerKeyBinding.htm
    public partial  class frmCommandHandlerKeyBinding:Form
    {
        public frmCommandHandlerKeyBinding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCommandHandlerKeyBinding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCommandHandlerKeyBinding";
            this.Text = "frmCommandHandlerKeyBinding";
            this.Load += new System.EventHandler(this.frmCommandHandlerKeyBinding_Load);
            this.ResumeLayout(false);

        }

        private void frmCommandHandlerKeyBinding_Load(object sender, EventArgs e)
        {

        }
    }
}
