using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0520__Grid
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SimpleGridxaml.htm
    public partial  class frmSimpleGridxaml:Form
    {
        public frmSimpleGridxaml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleGridxaml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleGridxaml";
            this.Text = "frmSimpleGridxaml";
            this.Load += new System.EventHandler(this.frmSimpleGridxaml_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleGridxaml_Load(object sender, EventArgs e)
        {

        }
    }
}
