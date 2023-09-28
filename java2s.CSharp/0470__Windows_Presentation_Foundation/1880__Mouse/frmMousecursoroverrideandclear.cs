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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Mousecursoroverrideandclear.htm
    public partial  class frmMousecursoroverrideandclear:Form
    {
        public frmMousecursoroverrideandclear()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMousecursoroverrideandclear
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMousecursoroverrideandclear";
            this.Text = "frmMousecursoroverrideandclear";
            this.Load += new System.EventHandler(this.frmMousecursoroverrideandclear_Load);
            this.ResumeLayout(false);

        }

        private void frmMousecursoroverrideandclear_Load(object sender, EventArgs e)
        {

        }
    }
}
