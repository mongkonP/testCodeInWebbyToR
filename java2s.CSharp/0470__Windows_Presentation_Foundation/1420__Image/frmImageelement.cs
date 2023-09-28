using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1420__Image
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Imageelement.htm
    public partial  class frmImageelement:Form
    {
        public frmImageelement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImageelement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImageelement";
            this.Text = "frmImageelement";
            this.Load += new System.EventHandler(this.frmImageelement_Load);
            this.ResumeLayout(false);

        }

        private void frmImageelement_Load(object sender, EventArgs e)
        {

        }
    }
}
