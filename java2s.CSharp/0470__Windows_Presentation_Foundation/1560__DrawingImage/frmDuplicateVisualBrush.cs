using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1560__DrawingImage
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DuplicateVisualBrush.htm
    public partial  class frmDuplicateVisualBrush:Form
    {
        public frmDuplicateVisualBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDuplicateVisualBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDuplicateVisualBrush";
            this.Text = "frmDuplicateVisualBrush";
            this.Load += new System.EventHandler(this.frmDuplicateVisualBrush_Load);
            this.ResumeLayout(false);

        }

        private void frmDuplicateVisualBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
