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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ReuseFontWithResources.htm
    public partial  class frmReuseFontWithResources:Form
    {
        public frmReuseFontWithResources()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReuseFontWithResources
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReuseFontWithResources";
            this.Text = "frmReuseFontWithResources";
            this.Load += new System.EventHandler(this.frmReuseFontWithResources_Load);
            this.ResumeLayout(false);

        }

        private void frmReuseFontWithResources_Load(object sender, EventArgs e)
        {

        }
    }
}
