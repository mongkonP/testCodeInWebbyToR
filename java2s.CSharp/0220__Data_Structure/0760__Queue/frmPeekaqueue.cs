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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Peekaqueue.htm
    public partial  class frmPeekaqueue:Form
    {
        public frmPeekaqueue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPeekaqueue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPeekaqueue";
            this.Text = "frmPeekaqueue";
            this.Load += new System.EventHandler(this.frmPeekaqueue_Load);
            this.ResumeLayout(false);

        }

        private void frmPeekaqueue_Load(object sender, EventArgs e)
        {

        }
    }
}
