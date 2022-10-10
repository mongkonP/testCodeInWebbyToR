using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0880__Func
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Doublerecursiveextension.htm
    public partial  class frmDoublerecursiveextension:Form
    {
        public frmDoublerecursiveextension()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDoublerecursiveextension
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDoublerecursiveextension";
            this.Text = "frmDoublerecursiveextension";
            this.Load += new System.EventHandler(this.frmDoublerecursiveextension_Load);
            this.ResumeLayout(false);

        }

        private void frmDoublerecursiveextension_Load(object sender, EventArgs e)
        {

        }
    }
}
