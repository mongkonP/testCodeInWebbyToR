using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2400__Xaml
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PropertyInheritance.htm
    public partial  class frmPropertyInheritance:Form
    {
        public frmPropertyInheritance()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPropertyInheritance
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPropertyInheritance";
            this.Text = "frmPropertyInheritance";
            this.Load += new System.EventHandler(this.frmPropertyInheritance_Load);
            this.ResumeLayout(false);

        }

        private void frmPropertyInheritance_Load(object sender, EventArgs e)
        {

        }
    }
}
