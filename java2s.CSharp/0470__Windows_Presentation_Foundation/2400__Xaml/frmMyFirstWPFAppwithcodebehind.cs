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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/MyFirstWPFAppwithcodebehind.htm
    public partial  class frmMyFirstWPFAppwithcodebehind:Form
    {
        public frmMyFirstWPFAppwithcodebehind()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMyFirstWPFAppwithcodebehind
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMyFirstWPFAppwithcodebehind";
            this.Text = "frmMyFirstWPFAppwithcodebehind";
            this.Load += new System.EventHandler(this.frmMyFirstWPFAppwithcodebehind_Load);
            this.ResumeLayout(false);

        }

        private void frmMyFirstWPFAppwithcodebehind_Load(object sender, EventArgs e)
        {

        }
    }
}
