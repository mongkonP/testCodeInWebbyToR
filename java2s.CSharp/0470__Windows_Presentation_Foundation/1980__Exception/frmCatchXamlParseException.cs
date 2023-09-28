using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1980__Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CatchXamlParseException.htm
    public partial  class frmCatchXamlParseException:Form
    {
        public frmCatchXamlParseException()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCatchXamlParseException
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCatchXamlParseException";
            this.Text = "frmCatchXamlParseException";
            this.Load += new System.EventHandler(this.frmCatchXamlParseException_Load);
            this.ResumeLayout(false);

        }

        private void frmCatchXamlParseException_Load(object sender, EventArgs e)
        {

        }
    }
}
