using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0040__CurrentUICulture
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/SetthecurrentUIculturefortheexecutingthread.htm
    public partial  class frmSetthecurrentUIculturefortheexecutingthread:Form
    {
        public frmSetthecurrentUIculturefortheexecutingthread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetthecurrentUIculturefortheexecutingthread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetthecurrentUIculturefortheexecutingthread";
            this.Text = "frmSetthecurrentUIculturefortheexecutingthread";
            this.Load += new System.EventHandler(this.frmSetthecurrentUIculturefortheexecutingthread_Load);
            this.ResumeLayout(false);

        }

        private void frmSetthecurrentUIculturefortheexecutingthread_Load(object sender, EventArgs e)
        {

        }
    }
}
