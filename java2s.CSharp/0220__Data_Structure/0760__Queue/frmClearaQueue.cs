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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ClearaQueue.htm
    public partial  class frmClearaQueue:Form
    {
        public frmClearaQueue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClearaQueue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClearaQueue";
            this.Text = "frmClearaQueue";
            this.Load += new System.EventHandler(this.frmClearaQueue_Load);
            this.ResumeLayout(false);

        }

        private void frmClearaQueue_Load(object sender, EventArgs e)
        {

        }
    }
}
