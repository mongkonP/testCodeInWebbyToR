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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ThrowHandledException.htm
    public partial  class frmThrowHandledException:Form
    {
        public frmThrowHandledException()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThrowHandledException
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThrowHandledException";
            this.Text = "frmThrowHandledException";
            this.Load += new System.EventHandler(this.frmThrowHandledException_Load);
            this.ResumeLayout(false);

        }

        private void frmThrowHandledException_Load(object sender, EventArgs e)
        {

        }
    }
}
