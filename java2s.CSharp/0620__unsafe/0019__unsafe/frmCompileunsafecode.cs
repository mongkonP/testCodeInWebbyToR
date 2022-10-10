using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0019__unsafe
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/Compileunsafecode.htm
    public partial  class frmCompileunsafecode:Form
    {
        public frmCompileunsafecode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCompileunsafecode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCompileunsafecode";
            this.Text = "frmCompileunsafecode";
            this.Load += new System.EventHandler(this.frmCompileunsafecode_Load);
            this.ResumeLayout(false);

        }

        private void frmCompileunsafecode_Load(object sender, EventArgs e)
        {

        }
    }
}
