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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/StartNotepadasthespecifieduser.htm
    public partial  class frmStartNotepadasthespecifieduser:Form
    {
        public frmStartNotepadasthespecifieduser()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStartNotepadasthespecifieduser
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStartNotepadasthespecifieduser";
            this.Text = "frmStartNotepadasthespecifieduser";
            this.Load += new System.EventHandler(this.frmStartNotepadasthespecifieduser_Load);
            this.ResumeLayout(false);

        }

        private void frmStartNotepadasthespecifieduser_Load(object sender, EventArgs e)
        {

        }
    }
}
