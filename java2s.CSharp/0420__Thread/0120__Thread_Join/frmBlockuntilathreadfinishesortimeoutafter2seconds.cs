using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0120__Thread_Join
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Blockuntilathreadfinishesortimeoutafter2seconds.htm
    public partial  class frmBlockuntilathreadfinishesortimeoutafter2seconds:Form
    {
        public frmBlockuntilathreadfinishesortimeoutafter2seconds()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBlockuntilathreadfinishesortimeoutafter2seconds
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBlockuntilathreadfinishesortimeoutafter2seconds";
            this.Text = "frmBlockuntilathreadfinishesortimeoutafter2seconds";
            this.Load += new System.EventHandler(this.frmBlockuntilathreadfinishesortimeoutafter2seconds_Load);
            this.ResumeLayout(false);

        }

        private void frmBlockuntilathreadfinishesortimeoutafter2seconds_Load(object sender, EventArgs e)
        {

        }
    }
}
