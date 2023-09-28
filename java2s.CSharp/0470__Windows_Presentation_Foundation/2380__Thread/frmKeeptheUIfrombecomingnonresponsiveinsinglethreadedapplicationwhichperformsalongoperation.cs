using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2380__Thread
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/KeeptheUIfrombecomingnonresponsiveinsinglethreadedapplicationwhichperformsalongoperation.htm
    public partial  class frmKeeptheUIfrombecomingnonresponsiveinsinglethreadedapplicationwhichperformsalongoperation:Form
    {
        public frmKeeptheUIfrombecomingnonresponsiveinsinglethreadedapplicationwhichperformsalongoperation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmKeeptheUIfrombecomingnonresponsiveinsinglethreadedapplicationwhichperformsalongoperation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmKeeptheUIfrombecomingnonresponsiveinsinglethreadedapplicationwhichperformsalongoperation";
            this.Text = "frmKeeptheUIfrombecomingnonresponsiveinsinglethreadedapplicationwhichperformsalongoperation";
            this.Load += new System.EventHandler(this.frmKeeptheUIfrombecomingnonresponsiveinsinglethreadedapplicationwhichperformsalongoperation_Load);
            this.ResumeLayout(false);

        }

        private void frmKeeptheUIfrombecomingnonresponsiveinsinglethreadedapplicationwhichperformsalongoperation_Load(object sender, EventArgs e)
        {

        }
    }
}
