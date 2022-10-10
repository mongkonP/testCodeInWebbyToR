using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1800__Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RaisetheScrollChangedeventofaScrollViewer.htm
    public partial  class frmRaisetheScrollChangedeventofaScrollViewer:Form
    {
        public frmRaisetheScrollChangedeventofaScrollViewer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRaisetheScrollChangedeventofaScrollViewer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRaisetheScrollChangedeventofaScrollViewer";
            this.Text = "frmRaisetheScrollChangedeventofaScrollViewer";
            this.Load += new System.EventHandler(this.frmRaisetheScrollChangedeventofaScrollViewer_Load);
            this.ResumeLayout(false);

        }

        private void frmRaisetheScrollChangedeventofaScrollViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
