using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0540__GridSplitter
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GridWithSplitter.htm
    public partial  class frmGridWithSplitter:Form
    {
        public frmGridWithSplitter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGridWithSplitter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGridWithSplitter";
            this.Text = "frmGridWithSplitter";
            this.Load += new System.EventHandler(this.frmGridWithSplitter_Load);
            this.ResumeLayout(false);

        }

        private void frmGridWithSplitter_Load(object sender, EventArgs e)
        {

        }
    }
}