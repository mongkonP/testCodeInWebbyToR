using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0160__delegate_event
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Creatinganevent.htm
    public partial  class frmCreatinganevent:Form
    {
        public frmCreatinganevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatinganevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatinganevent";
            this.Text = "frmCreatinganevent";
            this.Load += new System.EventHandler(this.frmCreatinganevent_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatinganevent_Load(object sender, EventArgs e)
        {

        }
    }
}