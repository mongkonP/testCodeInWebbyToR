using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0160__Windows_Application_Process
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/TerminatingNotepadwithKill.htm
    public partial  class frmTerminatingNotepadwithKill:Form
    {
        public frmTerminatingNotepadwithKill()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTerminatingNotepadwithKill
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTerminatingNotepadwithKill";
            this.Text = "frmTerminatingNotepadwithKill";
            this.Load += new System.EventHandler(this.frmTerminatingNotepadwithKill_Load);
            this.ResumeLayout(false);

        }

        private void frmTerminatingNotepadwithKill_Load(object sender, EventArgs e)
        {

        }
    }
}
