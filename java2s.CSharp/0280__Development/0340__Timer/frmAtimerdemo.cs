using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0340__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Atimerdemo.htm
    public partial  class frmAtimerdemo:Form
    {
        public frmAtimerdemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAtimerdemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAtimerdemo";
            this.Text = "frmAtimerdemo";
            this.Load += new System.EventHandler(this.frmAtimerdemo_Load);
            this.ResumeLayout(false);

        }

        private void frmAtimerdemo_Load(object sender, EventArgs e)
        {

        }
    }
}
