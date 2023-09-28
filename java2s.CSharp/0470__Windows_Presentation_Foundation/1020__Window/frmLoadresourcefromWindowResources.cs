using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1020__Window
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LoadresourcefromWindowResources.htm
    public partial  class frmLoadresourcefromWindowResources:Form
    {
        public frmLoadresourcefromWindowResources()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadresourcefromWindowResources
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadresourcefromWindowResources";
            this.Text = "frmLoadresourcefromWindowResources";
            this.Load += new System.EventHandler(this.frmLoadresourcefromWindowResources_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadresourcefromWindowResources_Load(object sender, EventArgs e)
        {

        }
    }
}
