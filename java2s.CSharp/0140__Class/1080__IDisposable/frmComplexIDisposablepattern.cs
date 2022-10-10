using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C1080__IDisposable
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ComplexIDisposablepattern.htm
    public partial  class frmComplexIDisposablepattern:Form
    {
        public frmComplexIDisposablepattern()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmComplexIDisposablepattern
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmComplexIDisposablepattern";
            this.Text = "frmComplexIDisposablepattern";
            this.Load += new System.EventHandler(this.frmComplexIDisposablepattern_Load);
            this.ResumeLayout(false);

        }

        private void frmComplexIDisposablepattern_Load(object sender, EventArgs e)
        {

        }
    }
}
