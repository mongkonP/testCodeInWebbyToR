using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0023__Button_Action
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Doeventbasedonbuttonname.htm
    public partial  class frmDoeventbasedonbuttonname:Form
    {
        public frmDoeventbasedonbuttonname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDoeventbasedonbuttonname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDoeventbasedonbuttonname";
            this.Text = "frmDoeventbasedonbuttonname";
            this.Load += new System.EventHandler(this.frmDoeventbasedonbuttonname_Load);
            this.ResumeLayout(false);

        }

        private void frmDoeventbasedonbuttonname_Load(object sender, EventArgs e)
        {

        }
    }
}
