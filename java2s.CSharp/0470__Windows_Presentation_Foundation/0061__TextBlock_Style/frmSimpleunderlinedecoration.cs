using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0061__TextBlock_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Simpleunderlinedecoration.htm
    public partial  class frmSimpleunderlinedecoration:Form
    {
        public frmSimpleunderlinedecoration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleunderlinedecoration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleunderlinedecoration";
            this.Text = "frmSimpleunderlinedecoration";
            this.Load += new System.EventHandler(this.frmSimpleunderlinedecoration_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleunderlinedecoration_Load(object sender, EventArgs e)
        {

        }
    }
}
