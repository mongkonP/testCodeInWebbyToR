using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0160__Thread_Priority
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UserThreadNameApartmentStateIsAlivePriorityThreadState.htm
    public partial  class frmUserThreadNameApartmentStateIsAlivePriorityThreadState:Form
    {
        public frmUserThreadNameApartmentStateIsAlivePriorityThreadState()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUserThreadNameApartmentStateIsAlivePriorityThreadState
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUserThreadNameApartmentStateIsAlivePriorityThreadState";
            this.Text = "frmUserThreadNameApartmentStateIsAlivePriorityThreadState";
            this.Load += new System.EventHandler(this.frmUserThreadNameApartmentStateIsAlivePriorityThreadState_Load);
            this.ResumeLayout(false);

        }

        private void frmUserThreadNameApartmentStateIsAlivePriorityThreadState_Load(object sender, EventArgs e)
        {

        }
    }
}
