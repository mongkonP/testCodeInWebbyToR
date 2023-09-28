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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CustomizeUpdateSourceExceptionFilter.htm
    public partial  class frmCustomizeUpdateSourceExceptionFilter:Form
    {
        public frmCustomizeUpdateSourceExceptionFilter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCustomizeUpdateSourceExceptionFilter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCustomizeUpdateSourceExceptionFilter";
            this.Text = "frmCustomizeUpdateSourceExceptionFilter";
            this.Load += new System.EventHandler(this.frmCustomizeUpdateSourceExceptionFilter_Load);
            this.ResumeLayout(false);

        }

        private void frmCustomizeUpdateSourceExceptionFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
