using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1180__Brush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ColormapBrush.htm
    public partial  class frmColormapBrush:Form
    {
        public frmColormapBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmColormapBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmColormapBrush";
            this.Text = "frmColormapBrush";
            this.Load += new System.EventHandler(this.frmColormapBrush_Load);
            this.ResumeLayout(false);

        }

        private void frmColormapBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
