using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0280__Office
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Officecommandbar.htm
    public partial  class frmOfficecommandbar:Form
    {
        public frmOfficecommandbar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOfficecommandbar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOfficecommandbar";
            this.Text = "frmOfficecommandbar";
            this.Load += new System.EventHandler(this.frmOfficecommandbar_Load);
            this.ResumeLayout(false);

        }

        private void frmOfficecommandbar_Load(object sender, EventArgs e)
        {

        }
    }
}
