using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2120__Resource
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EventSetterfromResources.htm
    public partial  class frmEventSetterfromResources:Form
    {
        public frmEventSetterfromResources()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEventSetterfromResources
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEventSetterfromResources";
            this.Text = "frmEventSetterfromResources";
            this.Load += new System.EventHandler(this.frmEventSetterfromResources_Load);
            this.ResumeLayout(false);

        }

        private void frmEventSetterfromResources_Load(object sender, EventArgs e)
        {

        }
    }
}
