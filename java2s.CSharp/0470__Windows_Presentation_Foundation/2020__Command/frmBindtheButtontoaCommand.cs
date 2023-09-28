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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindtheButtontoaCommand.htm
    public partial  class frmBindtheButtontoaCommand:Form
    {
        public frmBindtheButtontoaCommand()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindtheButtontoaCommand
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindtheButtontoaCommand";
            this.Text = "frmBindtheButtontoaCommand";
            this.Load += new System.EventHandler(this.frmBindtheButtontoaCommand_Load);
            this.ResumeLayout(false);

        }

        private void frmBindtheButtontoaCommand_Load(object sender, EventArgs e)
        {

        }
    }
}
