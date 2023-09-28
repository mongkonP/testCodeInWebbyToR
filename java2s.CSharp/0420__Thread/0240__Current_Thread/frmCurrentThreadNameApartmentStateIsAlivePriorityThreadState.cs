using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0240__Current_Thread
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/CurrentThreadNameApartmentStateIsAlivePriorityThreadState.htm
    public partial  class frmCurrentThreadNameApartmentStateIsAlivePriorityThreadState:Form
    {
        public frmCurrentThreadNameApartmentStateIsAlivePriorityThreadState()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCurrentThreadNameApartmentStateIsAlivePriorityThreadState
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCurrentThreadNameApartmentStateIsAlivePriorityThreadState";
            this.Text = "frmCurrentThreadNameApartmentStateIsAlivePriorityThreadState";
            this.Load += new System.EventHandler(this.frmCurrentThreadNameApartmentStateIsAlivePriorityThreadState_Load);
            this.ResumeLayout(false);

        }

        private void frmCurrentThreadNameApartmentStateIsAlivePriorityThreadState_Load(object sender, EventArgs e)
        {

        }
    }
}
