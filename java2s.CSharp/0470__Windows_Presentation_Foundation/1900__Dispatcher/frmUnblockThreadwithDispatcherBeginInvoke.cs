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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UnblockThreadwithDispatcherBeginInvoke.htm
    public partial  class frmUnblockThreadwithDispatcherBeginInvoke:Form
    {
        public frmUnblockThreadwithDispatcherBeginInvoke()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUnblockThreadwithDispatcherBeginInvoke
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUnblockThreadwithDispatcherBeginInvoke";
            this.Text = "frmUnblockThreadwithDispatcherBeginInvoke";
            this.Load += new System.EventHandler(this.frmUnblockThreadwithDispatcherBeginInvoke_Load);
            this.ResumeLayout(false);

        }

        private void frmUnblockThreadwithDispatcherBeginInvoke_Load(object sender, EventArgs e)
        {

        }
    }
}
