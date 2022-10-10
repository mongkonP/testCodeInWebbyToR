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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DispatcherBeginInvokewithDispatcherPriorityNormal.htm
    public partial  class frmDispatcherBeginInvokewithDispatcherPriorityNormal:Form
    {
        public frmDispatcherBeginInvokewithDispatcherPriorityNormal()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDispatcherBeginInvokewithDispatcherPriorityNormal
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDispatcherBeginInvokewithDispatcherPriorityNormal";
            this.Text = "frmDispatcherBeginInvokewithDispatcherPriorityNormal";
            this.Load += new System.EventHandler(this.frmDispatcherBeginInvokewithDispatcherPriorityNormal_Load);
            this.ResumeLayout(false);

        }

        private void frmDispatcherBeginInvokewithDispatcherPriorityNormal_Load(object sender, EventArgs e)
        {

        }
    }
}
