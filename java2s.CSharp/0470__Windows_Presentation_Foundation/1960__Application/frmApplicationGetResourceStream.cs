using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1960__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ApplicationGetResourceStream.htm
    public partial  class frmApplicationGetResourceStream:Form
    {
        public frmApplicationGetResourceStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmApplicationGetResourceStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmApplicationGetResourceStream";
            this.Text = "frmApplicationGetResourceStream";
            this.Load += new System.EventHandler(this.frmApplicationGetResourceStream_Load);
            this.ResumeLayout(false);

        }

        private void frmApplicationGetResourceStream_Load(object sender, EventArgs e)
        {

        }
    }
}
