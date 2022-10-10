using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1880__Mouse
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GridMouseLeftButtonUp.htm
    public partial  class frmGridMouseLeftButtonUp:Form
    {
        public frmGridMouseLeftButtonUp()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGridMouseLeftButtonUp
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGridMouseLeftButtonUp";
            this.Text = "frmGridMouseLeftButtonUp";
            this.Load += new System.EventHandler(this.frmGridMouseLeftButtonUp_Load);
            this.ResumeLayout(false);

        }

        private void frmGridMouseLeftButtonUp_Load(object sender, EventArgs e)
        {

        }
    }
}
