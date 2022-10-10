using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2003__Bind_to_TextBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindToTextBoxBackandForth.htm
    public partial  class frmBindToTextBoxBackandForth:Form
    {
        public frmBindToTextBoxBackandForth()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindToTextBoxBackandForth
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindToTextBoxBackandForth";
            this.Text = "frmBindToTextBoxBackandForth";
            this.Load += new System.EventHandler(this.frmBindToTextBoxBackandForth_Load);
            this.ResumeLayout(false);

        }

        private void frmBindToTextBoxBackandForth_Load(object sender, EventArgs e)
        {

        }
    }
}
