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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Compilecsharpsourcecodeincommandline.htm
    public partial  class frmCompilecsharpsourcecodeincommandline:Form
    {
        public frmCompilecsharpsourcecodeincommandline()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCompilecsharpsourcecodeincommandline
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCompilecsharpsourcecodeincommandline";
            this.Text = "frmCompilecsharpsourcecodeincommandline";
            this.Load += new System.EventHandler(this.frmCompilecsharpsourcecodeincommandline_Load);
            this.ResumeLayout(false);

        }

        private void frmCompilecsharpsourcecodeincommandline_Load(object sender, EventArgs e)
        {

        }
    }
}
