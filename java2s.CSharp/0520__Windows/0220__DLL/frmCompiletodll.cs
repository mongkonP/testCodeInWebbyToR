using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0220__DLL
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Compiletodll.htm
    public partial  class frmCompiletodll:Form
    {
        public frmCompiletodll()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCompiletodll
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCompiletodll";
            this.Text = "frmCompiletodll";
            this.Load += new System.EventHandler(this.frmCompiletodll_Load);
            this.ResumeLayout(false);

        }

        private void frmCompiletodll_Load(object sender, EventArgs e)
        {

        }
    }
}
