using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0060__Comments
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/UsecommentinC.htm
    public partial  class frmUsecommentinC:Form
    {
        public frmUsecommentinC()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsecommentinC
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsecommentinC";
            this.Text = "frmUsecommentinC";
            this.Load += new System.EventHandler(this.frmUsecommentinC_Load);
            this.ResumeLayout(false);

        }

        private void frmUsecommentinC_Load(object sender, EventArgs e)
        {

        }
    }
}
