using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0820__Margin
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Nomargin.htm
    public partial  class frmNomargin:Form
    {
        public frmNomargin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNomargin
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNomargin";
            this.Text = "frmNomargin";
            this.Load += new System.EventHandler(this.frmNomargin_Load);
            this.ResumeLayout(false);

        }

        private void frmNomargin_Load(object sender, EventArgs e)
        {

        }
    }
}
