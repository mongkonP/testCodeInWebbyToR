using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0020__Thread_Creation
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Createmultiplethreadsofexecution.htm
    public partial  class frmCreatemultiplethreadsofexecution:Form
    {
        public frmCreatemultiplethreadsofexecution()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatemultiplethreadsofexecution
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatemultiplethreadsofexecution";
            this.Text = "frmCreatemultiplethreadsofexecution";
            this.Load += new System.EventHandler(this.frmCreatemultiplethreadsofexecution_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatemultiplethreadsofexecution_Load(object sender, EventArgs e)
        {

        }
    }
}
