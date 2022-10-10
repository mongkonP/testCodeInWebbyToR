using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0380__Menu
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Amainmenu.htm
    public partial  class frmAmainmenu:Form
    {
        public frmAmainmenu()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAmainmenu
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAmainmenu";
            this.Text = "frmAmainmenu";
            this.Load += new System.EventHandler(this.frmAmainmenu_Load);
            this.ResumeLayout(false);

        }

        private void frmAmainmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
