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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ToolBarandeventhandler.htm
    public partial  class frmToolBarandeventhandler:Form
    {
        public frmToolBarandeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToolBarandeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToolBarandeventhandler";
            this.Text = "frmToolBarandeventhandler";
            this.Load += new System.EventHandler(this.frmToolBarandeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmToolBarandeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
