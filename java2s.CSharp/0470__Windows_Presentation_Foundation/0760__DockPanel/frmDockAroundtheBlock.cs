using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0760__DockPanel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DockAroundtheBlock.htm
    public partial  class frmDockAroundtheBlock:Form
    {
        public frmDockAroundtheBlock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDockAroundtheBlock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDockAroundtheBlock";
            this.Text = "frmDockAroundtheBlock";
            this.Load += new System.EventHandler(this.frmDockAroundtheBlock_Load);
            this.ResumeLayout(false);

        }

        private void frmDockAroundtheBlock_Load(object sender, EventArgs e)
        {

        }
    }
}
