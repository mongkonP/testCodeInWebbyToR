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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Creatinganewevent.htm
    public partial  class frmCreatinganewevent:Form
    {
        public frmCreatinganewevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatinganewevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatinganewevent";
            this.Text = "frmCreatinganewevent";
            this.Load += new System.EventHandler(this.frmCreatinganewevent_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatinganewevent_Load(object sender, EventArgs e)
        {

        }
    }
}
