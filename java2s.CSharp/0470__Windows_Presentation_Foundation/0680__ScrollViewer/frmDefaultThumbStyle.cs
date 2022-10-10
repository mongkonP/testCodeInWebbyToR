using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0680__ScrollViewer
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DefaultThumbStyle.htm
    public partial  class frmDefaultThumbStyle:Form
    {
        public frmDefaultThumbStyle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefaultThumbStyle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefaultThumbStyle";
            this.Text = "frmDefaultThumbStyle";
            this.Load += new System.EventHandler(this.frmDefaultThumbStyle_Load);
            this.ResumeLayout(false);

        }

        private void frmDefaultThumbStyle_Load(object sender, EventArgs e)
        {

        }
    }
}
