using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0100__Custom_Format
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/formatinlowercasehex.htm
    public partial  class frmformatinlowercasehex:Form
    {
        public frmformatinlowercasehex()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmformatinlowercasehex
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmformatinlowercasehex";
            this.Text = "frmformatinlowercasehex";
            this.Load += new System.EventHandler(this.frmformatinlowercasehex_Load);
            this.ResumeLayout(false);

        }

        private void frmformatinlowercasehex_Load(object sender, EventArgs e)
        {

        }
    }
}
