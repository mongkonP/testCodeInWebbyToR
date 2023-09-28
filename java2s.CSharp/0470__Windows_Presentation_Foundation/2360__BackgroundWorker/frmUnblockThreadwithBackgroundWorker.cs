using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2360__BackgroundWorker
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UnblockThreadwithBackgroundWorker.htm
    public partial  class frmUnblockThreadwithBackgroundWorker:Form
    {
        public frmUnblockThreadwithBackgroundWorker()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUnblockThreadwithBackgroundWorker
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUnblockThreadwithBackgroundWorker";
            this.Text = "frmUnblockThreadwithBackgroundWorker";
            this.Load += new System.EventHandler(this.frmUnblockThreadwithBackgroundWorker_Load);
            this.ResumeLayout(false);

        }

        private void frmUnblockThreadwithBackgroundWorker_Load(object sender, EventArgs e)
        {

        }
    }
}
