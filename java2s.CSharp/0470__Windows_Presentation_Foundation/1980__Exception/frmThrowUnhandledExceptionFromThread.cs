using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1980__Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ThrowUnhandledExceptionFromThread.htm
    public partial  class frmThrowUnhandledExceptionFromThread:Form
    {
        public frmThrowUnhandledExceptionFromThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThrowUnhandledExceptionFromThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThrowUnhandledExceptionFromThread";
            this.Text = "frmThrowUnhandledExceptionFromThread";
            this.Load += new System.EventHandler(this.frmThrowUnhandledExceptionFromThread_Load);
            this.ResumeLayout(false);

        }

        private void frmThrowUnhandledExceptionFromThread_Load(object sender, EventArgs e)
        {

        }
    }
}
