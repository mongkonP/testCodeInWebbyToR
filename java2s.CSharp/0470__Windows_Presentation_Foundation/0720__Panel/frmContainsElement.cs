using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0720__Panel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ContainsElement.htm
    public partial  class frmContainsElement:Form
    {
        public frmContainsElement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmContainsElement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmContainsElement";
            this.Text = "frmContainsElement";
            this.Load += new System.EventHandler(this.frmContainsElement_Load);
            this.ResumeLayout(false);

        }

        private void frmContainsElement_Load(object sender, EventArgs e)
        {

        }
    }
}
