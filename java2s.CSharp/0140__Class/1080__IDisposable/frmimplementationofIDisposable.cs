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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/implementationofIDisposable.htm
    public partial  class frmimplementationofIDisposable:Form
    {
        public frmimplementationofIDisposable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmimplementationofIDisposable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmimplementationofIDisposable";
            this.Text = "frmimplementationofIDisposable";
            this.Load += new System.EventHandler(this.frmimplementationofIDisposable_Load);
            this.ResumeLayout(false);

        }

        private void frmimplementationofIDisposable_Load(object sender, EventArgs e)
        {

        }
    }
}
