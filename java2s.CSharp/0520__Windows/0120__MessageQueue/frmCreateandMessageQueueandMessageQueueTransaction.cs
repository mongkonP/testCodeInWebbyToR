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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/CreateandMessageQueueandMessageQueueTransaction.htm
    public partial  class frmCreateandMessageQueueandMessageQueueTransaction:Form
    {
        public frmCreateandMessageQueueandMessageQueueTransaction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateandMessageQueueandMessageQueueTransaction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateandMessageQueueandMessageQueueTransaction";
            this.Text = "frmCreateandMessageQueueandMessageQueueTransaction";
            this.Load += new System.EventHandler(this.frmCreateandMessageQueueandMessageQueueTransaction_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateandMessageQueueandMessageQueueTransaction_Load(object sender, EventArgs e)
        {

        }
    }
}
