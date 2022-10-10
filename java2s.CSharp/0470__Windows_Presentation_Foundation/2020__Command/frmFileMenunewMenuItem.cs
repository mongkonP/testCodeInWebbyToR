using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2020__Command
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/FileMenunewMenuItem.htm
    public partial  class frmFileMenunewMenuItem:Form
    {
        public frmFileMenunewMenuItem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFileMenunewMenuItem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFileMenunewMenuItem";
            this.Text = "frmFileMenunewMenuItem";
            this.Load += new System.EventHandler(this.frmFileMenunewMenuItem_Load);
            this.ResumeLayout(false);

        }

        private void frmFileMenunewMenuItem_Load(object sender, EventArgs e)
        {

        }
    }
}
