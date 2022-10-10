using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0780__Stack
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/StackAndQueue.htm
    public partial  class frmStackAndQueue:Form
    {
        public frmStackAndQueue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStackAndQueue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStackAndQueue";
            this.Text = "frmStackAndQueue";
            this.Load += new System.EventHandler(this.frmStackAndQueue_Load);
            this.ResumeLayout(false);

        }

        private void frmStackAndQueue_Load(object sender, EventArgs e)
        {

        }
    }
}
