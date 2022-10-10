using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0580__UI_Element
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Changinggraphicalelements.htm
    public partial  class frmChanginggraphicalelements:Form
    {
        public frmChanginggraphicalelements()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChanginggraphicalelements
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChanginggraphicalelements";
            this.Text = "frmChanginggraphicalelements";
            this.Load += new System.EventHandler(this.frmChanginggraphicalelements_Load);
            this.ResumeLayout(false);

        }

        private void frmChanginggraphicalelements_Load(object sender, EventArgs e)
        {

        }
    }
}
