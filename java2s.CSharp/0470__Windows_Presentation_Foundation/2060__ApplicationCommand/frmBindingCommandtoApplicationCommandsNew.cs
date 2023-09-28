using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2060__ApplicationCommand
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindingCommandtoApplicationCommandsNew.htm
    public partial  class frmBindingCommandtoApplicationCommandsNew:Form
    {
        public frmBindingCommandtoApplicationCommandsNew()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindingCommandtoApplicationCommandsNew
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindingCommandtoApplicationCommandsNew";
            this.Text = "frmBindingCommandtoApplicationCommandsNew";
            this.Load += new System.EventHandler(this.frmBindingCommandtoApplicationCommandsNew_Load);
            this.ResumeLayout(false);

        }

        private void frmBindingCommandtoApplicationCommandsNew_Load(object sender, EventArgs e)
        {

        }
    }
}
