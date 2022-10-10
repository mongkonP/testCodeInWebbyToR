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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CheckExceptiontypeforDispatcherUnhandledException.htm
    public partial  class frmCheckExceptiontypeforDispatcherUnhandledException:Form
    {
        public frmCheckExceptiontypeforDispatcherUnhandledException()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCheckExceptiontypeforDispatcherUnhandledException
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCheckExceptiontypeforDispatcherUnhandledException";
            this.Text = "frmCheckExceptiontypeforDispatcherUnhandledException";
            this.Load += new System.EventHandler(this.frmCheckExceptiontypeforDispatcherUnhandledException_Load);
            this.ResumeLayout(false);

        }

        private void frmCheckExceptiontypeforDispatcherUnhandledException_Load(object sender, EventArgs e)
        {

        }
    }
}
