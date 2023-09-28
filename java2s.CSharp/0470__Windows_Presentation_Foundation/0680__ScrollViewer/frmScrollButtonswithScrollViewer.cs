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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ScrollButtonswithScrollViewer.htm
    public partial  class frmScrollButtonswithScrollViewer:Form
    {
        public frmScrollButtonswithScrollViewer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmScrollButtonswithScrollViewer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmScrollButtonswithScrollViewer";
            this.Text = "frmScrollButtonswithScrollViewer";
            this.Load += new System.EventHandler(this.frmScrollButtonswithScrollViewer_Load);
            this.ResumeLayout(false);

        }

        private void frmScrollButtonswithScrollViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
