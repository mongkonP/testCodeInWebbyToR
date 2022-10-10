using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0120__MessageQueue
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/InternalTransactionProducer.htm
    public partial  class frmInternalTransactionProducer:Form
    {
        public frmInternalTransactionProducer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInternalTransactionProducer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInternalTransactionProducer";
            this.Text = "frmInternalTransactionProducer";
            this.Load += new System.EventHandler(this.frmInternalTransactionProducer_Load);
            this.ResumeLayout(false);

        }

        private void frmInternalTransactionProducer_Load(object sender, EventArgs e)
        {

        }
    }
}
