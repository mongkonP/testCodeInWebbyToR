using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2000__Binding
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WithoutBinding.htm
    public partial  class frmWithoutBinding:Form
    {
        public frmWithoutBinding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWithoutBinding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWithoutBinding";
            this.Text = "frmWithoutBinding";
            this.Load += new System.EventHandler(this.frmWithoutBinding_Load);
            this.ResumeLayout(false);

        }

        private void frmWithoutBinding_Load(object sender, EventArgs e)
        {

        }
    }
}
