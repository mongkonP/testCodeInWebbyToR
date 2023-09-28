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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsingGetContentStream.htm
    public partial  class frmUsingGetContentStream:Form
    {
        public frmUsingGetContentStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingGetContentStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingGetContentStream";
            this.Text = "frmUsingGetContentStream";
            this.Load += new System.EventHandler(this.frmUsingGetContentStream_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingGetContentStream_Load(object sender, EventArgs e)
        {

        }
    }
}
