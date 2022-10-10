using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0580__ThreadPool
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Registeringwaitcallbacksforevents.htm
    public partial  class frmRegisteringwaitcallbacksforevents:Form
    {
        public frmRegisteringwaitcallbacksforevents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRegisteringwaitcallbacksforevents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRegisteringwaitcallbacksforevents";
            this.Text = "frmRegisteringwaitcallbacksforevents";
            this.Load += new System.EventHandler(this.frmRegisteringwaitcallbacksforevents_Load);
            this.ResumeLayout(false);

        }

        private void frmRegisteringwaitcallbacksforevents_Load(object sender, EventArgs e)
        {

        }
    }
}
