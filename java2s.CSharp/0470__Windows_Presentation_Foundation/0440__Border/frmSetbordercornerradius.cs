using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0440__Border
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Setbordercornerradius.htm
    public partial  class frmSetbordercornerradius:Form
    {
        public frmSetbordercornerradius()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetbordercornerradius
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetbordercornerradius";
            this.Text = "frmSetbordercornerradius";
            this.Load += new System.EventHandler(this.frmSetbordercornerradius_Load);
            this.ResumeLayout(false);

        }

        private void frmSetbordercornerradius_Load(object sender, EventArgs e)
        {

        }
    }
}
