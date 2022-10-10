using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0160__CheckBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CheckBoxStyle.htm
    public partial  class frmCheckBoxStyle:Form
    {
        public frmCheckBoxStyle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCheckBoxStyle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCheckBoxStyle";
            this.Text = "frmCheckBoxStyle";
            this.Load += new System.EventHandler(this.frmCheckBoxStyle_Load);
            this.ResumeLayout(false);

        }

        private void frmCheckBoxStyle_Load(object sender, EventArgs e)
        {

        }
    }
}
