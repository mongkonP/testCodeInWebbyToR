using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0020__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/WorkingwithThreadExceptions.htm
    public partial  class frmWorkingwithThreadExceptions:Form
    {
        public frmWorkingwithThreadExceptions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWorkingwithThreadExceptions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWorkingwithThreadExceptions";
            this.Text = "frmWorkingwithThreadExceptions";
            this.Load += new System.EventHandler(this.frmWorkingwithThreadExceptions_Load);
            this.ResumeLayout(false);

        }

        private void frmWorkingwithThreadExceptions_Load(object sender, EventArgs e)
        {

        }
    }
}
