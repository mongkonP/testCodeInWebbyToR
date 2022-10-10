using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0600__ToolBar
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ToolbarTrays.htm
    public partial  class frmToolbarTrays:Form
    {
        public frmToolbarTrays()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToolbarTrays
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToolbarTrays";
            this.Text = "frmToolbarTrays";
            this.Load += new System.EventHandler(this.frmToolbarTrays_Load);
            this.ResumeLayout(false);

        }

        private void frmToolbarTrays_Load(object sender, EventArgs e)
        {

        }
    }
}
