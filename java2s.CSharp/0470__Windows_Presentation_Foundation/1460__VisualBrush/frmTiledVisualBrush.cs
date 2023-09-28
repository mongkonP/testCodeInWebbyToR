using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1460__VisualBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TiledVisualBrush.htm
    public partial  class frmTiledVisualBrush:Form
    {
        public frmTiledVisualBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTiledVisualBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTiledVisualBrush";
            this.Text = "frmTiledVisualBrush";
            this.Load += new System.EventHandler(this.frmTiledVisualBrush_Load);
            this.ResumeLayout(false);

        }

        private void frmTiledVisualBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
