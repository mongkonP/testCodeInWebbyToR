using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0040__Environment
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/EnvironmentNewLine.htm
    public partial  class frmEnvironmentNewLine:Form
    {
        public frmEnvironmentNewLine()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnvironmentNewLine
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnvironmentNewLine";
            this.Text = "frmEnvironmentNewLine";
            this.Load += new System.EventHandler(this.frmEnvironmentNewLine_Load);
            this.ResumeLayout(false);

        }

        private void frmEnvironmentNewLine_Load(object sender, EventArgs e)
        {

        }
    }
}
