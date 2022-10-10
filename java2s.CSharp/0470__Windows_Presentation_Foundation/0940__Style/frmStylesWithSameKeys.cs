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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/StylesWithSameKeys.htm
    public partial  class frmStylesWithSameKeys:Form
    {
        public frmStylesWithSameKeys()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStylesWithSameKeys
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStylesWithSameKeys";
            this.Text = "frmStylesWithSameKeys";
            this.Load += new System.EventHandler(this.frmStylesWithSameKeys_Load);
            this.ResumeLayout(false);

        }

        private void frmStylesWithSameKeys_Load(object sender, EventArgs e)
        {

        }
    }
}
