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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/StretchUniform.htm
    public partial  class frmStretchUniform:Form
    {
        public frmStretchUniform()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStretchUniform
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStretchUniform";
            this.Text = "frmStretchUniform";
            this.Load += new System.EventHandler(this.frmStretchUniform_Load);
            this.ResumeLayout(false);

        }

        private void frmStretchUniform_Load(object sender, EventArgs e)
        {

        }
    }
}
