using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0522__Grid_Events
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GridPreviewmousedownevent.htm
    public partial  class frmGridPreviewmousedownevent:Form
    {
        public frmGridPreviewmousedownevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGridPreviewmousedownevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGridPreviewmousedownevent";
            this.Text = "frmGridPreviewmousedownevent";
            this.Load += new System.EventHandler(this.frmGridPreviewmousedownevent_Load);
            this.ResumeLayout(false);

        }

        private void frmGridPreviewmousedownevent_Load(object sender, EventArgs e)
        {

        }
    }
}
