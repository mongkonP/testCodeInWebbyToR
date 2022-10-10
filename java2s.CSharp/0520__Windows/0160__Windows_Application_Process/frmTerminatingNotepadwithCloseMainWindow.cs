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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/TerminatingNotepadwithCloseMainWindow.htm
    public partial  class frmTerminatingNotepadwithCloseMainWindow:Form
    {
        public frmTerminatingNotepadwithCloseMainWindow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTerminatingNotepadwithCloseMainWindow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTerminatingNotepadwithCloseMainWindow";
            this.Text = "frmTerminatingNotepadwithCloseMainWindow";
            this.Load += new System.EventHandler(this.frmTerminatingNotepadwithCloseMainWindow_Load);
            this.ResumeLayout(false);

        }

        private void frmTerminatingNotepadwithCloseMainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
