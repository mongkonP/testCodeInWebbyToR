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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/StretchedGridSplitter.htm
    public partial  class frmStretchedGridSplitter:Form
    {
        public frmStretchedGridSplitter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStretchedGridSplitter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStretchedGridSplitter";
            this.Text = "frmStretchedGridSplitter";
            this.Load += new System.EventHandler(this.frmStretchedGridSplitter_Load);
            this.ResumeLayout(false);

        }

        private void frmStretchedGridSplitter_Load(object sender, EventArgs e)
        {

        }
    }
}
