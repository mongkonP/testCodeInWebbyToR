using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0760__Queue
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Creatingalistfromaqueue.htm
    public partial  class frmCreatingalistfromaqueue:Form
    {
        public frmCreatingalistfromaqueue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingalistfromaqueue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingalistfromaqueue";
            this.Text = "frmCreatingalistfromaqueue";
            this.Load += new System.EventHandler(this.frmCreatingalistfromaqueue_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingalistfromaqueue_Load(object sender, EventArgs e)
        {

        }
    }
}
