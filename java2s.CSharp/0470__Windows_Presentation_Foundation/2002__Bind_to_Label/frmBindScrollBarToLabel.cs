using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2002__Bind_to_Label
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindScrollBarToLabel.htm
    public partial  class frmBindScrollBarToLabel:Form
    {
        public frmBindScrollBarToLabel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindScrollBarToLabel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindScrollBarToLabel";
            this.Text = "frmBindScrollBarToLabel";
            this.Load += new System.EventHandler(this.frmBindScrollBarToLabel_Load);
            this.ResumeLayout(false);

        }

        private void frmBindScrollBarToLabel_Load(object sender, EventArgs e)
        {

        }
    }
}
