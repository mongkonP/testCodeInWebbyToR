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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Individualobjectsreceivenotificationswheninstanceeventhandlersareused.htm
    public partial  class frmIndividualobjectsreceivenotificationswheninstanceeventhandlersareused:Form
    {
        public frmIndividualobjectsreceivenotificationswheninstanceeventhandlersareused()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIndividualobjectsreceivenotificationswheninstanceeventhandlersareused
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIndividualobjectsreceivenotificationswheninstanceeventhandlersareused";
            this.Text = "frmIndividualobjectsreceivenotificationswheninstanceeventhandlersareused";
            this.Load += new System.EventHandler(this.frmIndividualobjectsreceivenotificationswheninstanceeventhandlersareused_Load);
            this.ResumeLayout(false);

        }

        private void frmIndividualobjectsreceivenotificationswheninstanceeventhandlersareused_Load(object sender, EventArgs e)
        {

        }
    }
}
