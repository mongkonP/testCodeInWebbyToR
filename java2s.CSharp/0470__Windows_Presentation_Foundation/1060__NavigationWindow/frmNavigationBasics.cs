using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1060__NavigationWindow
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/NavigationBasics.htm
    public partial  class frmNavigationBasics:Form
    {
        public frmNavigationBasics()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNavigationBasics
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNavigationBasics";
            this.Text = "frmNavigationBasics";
            this.Load += new System.EventHandler(this.frmNavigationBasics_Load);
            this.ResumeLayout(false);

        }

        private void frmNavigationBasics_Load(object sender, EventArgs e)
        {

        }
    }
}
