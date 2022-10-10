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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GridSplitterandDragIncrementChanged.htm
    public partial  class frmGridSplitterandDragIncrementChanged:Form
    {
        public frmGridSplitterandDragIncrementChanged()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGridSplitterandDragIncrementChanged
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGridSplitterandDragIncrementChanged";
            this.Text = "frmGridSplitterandDragIncrementChanged";
            this.Load += new System.EventHandler(this.frmGridSplitterandDragIncrementChanged_Load);
            this.ResumeLayout(false);

        }

        private void frmGridSplitterandDragIncrementChanged_Load(object sender, EventArgs e)
        {

        }
    }
}
