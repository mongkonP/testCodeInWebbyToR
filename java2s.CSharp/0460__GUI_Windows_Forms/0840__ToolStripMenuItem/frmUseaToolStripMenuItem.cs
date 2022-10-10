using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0840__ToolStripMenuItem
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/UseaToolStripMenuItem.htm
    public partial  class frmUseaToolStripMenuItem:Form
    {
        public frmUseaToolStripMenuItem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseaToolStripMenuItem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseaToolStripMenuItem";
            this.Text = "frmUseaToolStripMenuItem";
            this.Load += new System.EventHandler(this.frmUseaToolStripMenuItem_Load);
            this.ResumeLayout(false);

        }

        private void frmUseaToolStripMenuItem_Load(object sender, EventArgs e)
        {

        }
    }
}
