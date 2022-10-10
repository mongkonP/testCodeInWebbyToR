using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0020__Intrduction
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/UsingcscexetheCCommandLineCompiler.htm
    public partial  class frmUsingcscexetheCCommandLineCompiler:Form
    {
        public frmUsingcscexetheCCommandLineCompiler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingcscexetheCCommandLineCompiler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingcscexetheCCommandLineCompiler";
            this.Text = "frmUsingcscexetheCCommandLineCompiler";
            this.Load += new System.EventHandler(this.frmUsingcscexetheCCommandLineCompiler_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingcscexetheCCommandLineCompiler_Load(object sender, EventArgs e)
        {

        }
    }
}
