using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1980__Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Manageunhandledexceptionsthatarethrownonsecondaryworkerthreads.htm
    public partial  class frmManageunhandledexceptionsthatarethrownonsecondaryworkerthreads:Form
    {
        public frmManageunhandledexceptionsthatarethrownonsecondaryworkerthreads()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmManageunhandledexceptionsthatarethrownonsecondaryworkerthreads
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmManageunhandledexceptionsthatarethrownonsecondaryworkerthreads";
            this.Text = "frmManageunhandledexceptionsthatarethrownonsecondaryworkerthreads";
            this.Load += new System.EventHandler(this.frmManageunhandledexceptionsthatarethrownonsecondaryworkerthreads_Load);
            this.ResumeLayout(false);

        }

        private void frmManageunhandledexceptionsthatarethrownonsecondaryworkerthreads_Load(object sender, EventArgs e)
        {

        }
    }
}
