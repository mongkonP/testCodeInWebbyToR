using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0200__using
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/IDisposableandtheusingKeyword.htm
    public partial  class frmIDisposableandtheusingKeyword:Form
    {
        public frmIDisposableandtheusingKeyword()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIDisposableandtheusingKeyword
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIDisposableandtheusingKeyword";
            this.Text = "frmIDisposableandtheusingKeyword";
            this.Load += new System.EventHandler(this.frmIDisposableandtheusingKeyword_Load);
            this.ResumeLayout(false);

        }

        private void frmIDisposableandtheusingKeyword_Load(object sender, EventArgs e)
        {

        }
    }
}
