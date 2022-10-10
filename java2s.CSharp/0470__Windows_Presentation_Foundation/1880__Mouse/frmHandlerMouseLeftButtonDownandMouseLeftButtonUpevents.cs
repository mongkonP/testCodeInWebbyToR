using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1880__Mouse
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/HandlerMouseLeftButtonDownandMouseLeftButtonUpevents.htm
    public partial  class frmHandlerMouseLeftButtonDownandMouseLeftButtonUpevents:Form
    {
        public frmHandlerMouseLeftButtonDownandMouseLeftButtonUpevents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandlerMouseLeftButtonDownandMouseLeftButtonUpevents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandlerMouseLeftButtonDownandMouseLeftButtonUpevents";
            this.Text = "frmHandlerMouseLeftButtonDownandMouseLeftButtonUpevents";
            this.Load += new System.EventHandler(this.frmHandlerMouseLeftButtonDownandMouseLeftButtonUpevents_Load);
            this.ResumeLayout(false);

        }

        private void frmHandlerMouseLeftButtonDownandMouseLeftButtonUpevents_Load(object sender, EventArgs e)
        {

        }
    }
}
