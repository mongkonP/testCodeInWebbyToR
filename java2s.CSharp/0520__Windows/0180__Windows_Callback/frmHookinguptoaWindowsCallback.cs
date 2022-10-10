using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0180__Windows_Callback
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/HookinguptoaWindowsCallback.htm
    public partial  class frmHookinguptoaWindowsCallback:Form
    {
        public frmHookinguptoaWindowsCallback()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHookinguptoaWindowsCallback
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHookinguptoaWindowsCallback";
            this.Text = "frmHookinguptoaWindowsCallback";
            this.Load += new System.EventHandler(this.frmHookinguptoaWindowsCallback_Load);
            this.ResumeLayout(false);

        }

        private void frmHookinguptoaWindowsCallback_Load(object sender, EventArgs e)
        {

        }
    }
}
