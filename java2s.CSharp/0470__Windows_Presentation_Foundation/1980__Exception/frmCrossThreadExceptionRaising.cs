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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CrossThreadExceptionRaising.htm
    public partial  class frmCrossThreadExceptionRaising:Form
    {
        public frmCrossThreadExceptionRaising()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCrossThreadExceptionRaising
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCrossThreadExceptionRaising";
            this.Text = "frmCrossThreadExceptionRaising";
            this.Load += new System.EventHandler(this.frmCrossThreadExceptionRaising_Load);
            this.ResumeLayout(false);

        }

        private void frmCrossThreadExceptionRaising_Load(object sender, EventArgs e)
        {

        }
    }
}
