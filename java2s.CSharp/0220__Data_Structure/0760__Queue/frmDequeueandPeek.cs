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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/DequeueandPeek.htm
    public partial  class frmDequeueandPeek:Form
    {
        public frmDequeueandPeek()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDequeueandPeek
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDequeueandPeek";
            this.Text = "frmDequeueandPeek";
            this.Load += new System.EventHandler(this.frmDequeueandPeek_Load);
            this.ResumeLayout(false);

        }

        private void frmDequeueandPeek_Load(object sender, EventArgs e)
        {

        }
    }
}
