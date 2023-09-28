using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1021__Window_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WindowPreviewKeyEvents.htm
    public partial  class frmWindowPreviewKeyEvents:Form
    {
        public frmWindowPreviewKeyEvents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWindowPreviewKeyEvents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWindowPreviewKeyEvents";
            this.Text = "frmWindowPreviewKeyEvents";
            this.Load += new System.EventHandler(this.frmWindowPreviewKeyEvents_Load);
            this.ResumeLayout(false);

        }

        private void frmWindowPreviewKeyEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
