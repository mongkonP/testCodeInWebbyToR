using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0680__ScrollViewer
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PutCanvasintoScrollViewer.htm
    public partial  class frmPutCanvasintoScrollViewer:Form
    {
        public frmPutCanvasintoScrollViewer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPutCanvasintoScrollViewer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPutCanvasintoScrollViewer";
            this.Text = "frmPutCanvasintoScrollViewer";
            this.Load += new System.EventHandler(this.frmPutCanvasintoScrollViewer_Load);
            this.ResumeLayout(false);

        }

        private void frmPutCanvasintoScrollViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
