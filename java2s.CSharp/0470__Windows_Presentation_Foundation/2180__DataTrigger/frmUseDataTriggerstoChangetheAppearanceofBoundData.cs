using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2180__DataTrigger
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseDataTriggerstoChangetheAppearanceofBoundData.htm
    public partial  class frmUseDataTriggerstoChangetheAppearanceofBoundData:Form
    {
        public frmUseDataTriggerstoChangetheAppearanceofBoundData()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseDataTriggerstoChangetheAppearanceofBoundData
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseDataTriggerstoChangetheAppearanceofBoundData";
            this.Text = "frmUseDataTriggerstoChangetheAppearanceofBoundData";
            this.Load += new System.EventHandler(this.frmUseDataTriggerstoChangetheAppearanceofBoundData_Load);
            this.ResumeLayout(false);

        }

        private void frmUseDataTriggerstoChangetheAppearanceofBoundData_Load(object sender, EventArgs e)
        {

        }
    }
}
