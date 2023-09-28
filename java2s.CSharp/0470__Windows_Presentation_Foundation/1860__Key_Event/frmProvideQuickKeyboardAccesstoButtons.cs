using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1860__Key_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ProvideQuickKeyboardAccesstoButtons.htm
    public partial  class frmProvideQuickKeyboardAccesstoButtons:Form
    {
        public frmProvideQuickKeyboardAccesstoButtons()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProvideQuickKeyboardAccesstoButtons
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProvideQuickKeyboardAccesstoButtons";
            this.Text = "frmProvideQuickKeyboardAccesstoButtons";
            this.Load += new System.EventHandler(this.frmProvideQuickKeyboardAccesstoButtons_Load);
            this.ResumeLayout(false);

        }

        private void frmProvideQuickKeyboardAccesstoButtons_Load(object sender, EventArgs e)
        {

        }
    }
}
