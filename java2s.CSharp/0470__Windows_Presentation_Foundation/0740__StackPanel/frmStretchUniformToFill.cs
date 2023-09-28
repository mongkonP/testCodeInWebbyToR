using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0740__StackPanel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/StretchUniformToFill.htm
    public partial  class frmStretchUniformToFill:Form
    {
        public frmStretchUniformToFill()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStretchUniformToFill
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStretchUniformToFill";
            this.Text = "frmStretchUniformToFill";
            this.Load += new System.EventHandler(this.frmStretchUniformToFill_Load);
            this.ResumeLayout(false);

        }

        private void frmStretchUniformToFill_Load(object sender, EventArgs e)
        {

        }
    }
}
