using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0100__While
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Usecountnumbertocontrolwhileloop.htm
    public partial  class frmUsecountnumbertocontrolwhileloop:Form
    {
        public frmUsecountnumbertocontrolwhileloop()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsecountnumbertocontrolwhileloop
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsecountnumbertocontrolwhileloop";
            this.Text = "frmUsecountnumbertocontrolwhileloop";
            this.Load += new System.EventHandler(this.frmUsecountnumbertocontrolwhileloop_Load);
            this.ResumeLayout(false);

        }

        private void frmUsecountnumbertocontrolwhileloop_Load(object sender, EventArgs e)
        {

        }
    }
}
