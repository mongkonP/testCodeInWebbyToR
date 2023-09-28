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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Receivemessage.htm
    public partial  class frmReceivemessage:Form
    {
        public frmReceivemessage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReceivemessage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReceivemessage";
            this.Text = "frmReceivemessage";
            this.Load += new System.EventHandler(this.frmReceivemessage_Load);
            this.ResumeLayout(false);

        }

        private void frmReceivemessage_Load(object sender, EventArgs e)
        {

        }
    }
}
