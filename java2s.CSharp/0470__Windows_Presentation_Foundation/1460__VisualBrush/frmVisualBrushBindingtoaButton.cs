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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/VisualBrushBindingtoaButton.htm
    public partial  class frmVisualBrushBindingtoaButton:Form
    {
        public frmVisualBrushBindingtoaButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVisualBrushBindingtoaButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVisualBrushBindingtoaButton";
            this.Text = "frmVisualBrushBindingtoaButton";
            this.Load += new System.EventHandler(this.frmVisualBrushBindingtoaButton_Load);
            this.ResumeLayout(false);

        }

        private void frmVisualBrushBindingtoaButton_Load(object sender, EventArgs e)
        {

        }
    }
}
