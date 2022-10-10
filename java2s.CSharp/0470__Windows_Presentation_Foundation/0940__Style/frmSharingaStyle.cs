using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0940__Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SharingaStyle.htm
    public partial  class frmSharingaStyle:Form
    {
        public frmSharingaStyle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSharingaStyle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSharingaStyle";
            this.Text = "frmSharingaStyle";
            this.Load += new System.EventHandler(this.frmSharingaStyle_Load);
            this.ResumeLayout(false);

        }

        private void frmSharingaStyle_Load(object sender, EventArgs e)
        {

        }
    }
}
