using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1700__Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RemoveAnimations.htm
    public partial  class frmRemoveAnimations:Form
    {
        public frmRemoveAnimations()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRemoveAnimations
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRemoveAnimations";
            this.Text = "frmRemoveAnimations";
            this.Load += new System.EventHandler(this.frmRemoveAnimations_Load);
            this.ResumeLayout(false);

        }

        private void frmRemoveAnimations_Load(object sender, EventArgs e)
        {

        }
    }
}
