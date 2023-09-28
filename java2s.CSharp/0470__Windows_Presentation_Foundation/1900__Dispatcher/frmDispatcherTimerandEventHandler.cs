using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1900__Dispatcher
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DispatcherTimerandEventHandler.htm
    public partial  class frmDispatcherTimerandEventHandler:Form
    {
        public frmDispatcherTimerandEventHandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDispatcherTimerandEventHandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDispatcherTimerandEventHandler";
            this.Text = "frmDispatcherTimerandEventHandler";
            this.Load += new System.EventHandler(this.frmDispatcherTimerandEventHandler_Load);
            this.ResumeLayout(false);

        }

        private void frmDispatcherTimerandEventHandler_Load(object sender, EventArgs e)
        {

        }
    }
}
