using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1580__LinearGradientBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GradientStopCollection.htm
    public partial  class frmGradientStopCollection:Form
    {
        public frmGradientStopCollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGradientStopCollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGradientStopCollection";
            this.Text = "frmGradientStopCollection";
            this.Load += new System.EventHandler(this.frmGradientStopCollection_Load);
            this.ResumeLayout(false);

        }

        private void frmGradientStopCollection_Load(object sender, EventArgs e)
        {

        }
    }
}
