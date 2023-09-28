using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2400__Xaml
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateButtonfromXamlstring.htm
    public partial  class frmCreateButtonfromXamlstring:Form
    {
        public frmCreateButtonfromXamlstring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateButtonfromXamlstring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateButtonfromXamlstring";
            this.Text = "frmCreateButtonfromXamlstring";
            this.Load += new System.EventHandler(this.frmCreateButtonfromXamlstring_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateButtonfromXamlstring_Load(object sender, EventArgs e)
        {

        }
    }
}
