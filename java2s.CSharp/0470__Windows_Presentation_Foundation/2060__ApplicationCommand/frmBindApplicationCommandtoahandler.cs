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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindApplicationCommandtoahandler.htm
    public partial  class frmBindApplicationCommandtoahandler:Form
    {
        public frmBindApplicationCommandtoahandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindApplicationCommandtoahandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindApplicationCommandtoahandler";
            this.Text = "frmBindApplicationCommandtoahandler";
            this.Load += new System.EventHandler(this.frmBindApplicationCommandtoahandler_Load);
            this.ResumeLayout(false);

        }

        private void frmBindApplicationCommandtoahandler_Load(object sender, EventArgs e)
        {

        }
    }
}
