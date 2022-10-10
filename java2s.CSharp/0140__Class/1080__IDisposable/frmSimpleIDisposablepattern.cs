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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/SimpleIDisposablepattern.htm
    public partial  class frmSimpleIDisposablepattern:Form
    {
        public frmSimpleIDisposablepattern()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleIDisposablepattern
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleIDisposablepattern";
            this.Text = "frmSimpleIDisposablepattern";
            this.Load += new System.EventHandler(this.frmSimpleIDisposablepattern_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleIDisposablepattern_Load(object sender, EventArgs e)
        {

        }
    }
}
