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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/formatinuppercasehex.htm
    public partial  class frmformatinuppercasehex:Form
    {
        public frmformatinuppercasehex()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmformatinuppercasehex
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmformatinuppercasehex";
            this.Text = "frmformatinuppercasehex";
            this.Load += new System.EventHandler(this.frmformatinuppercasehex_Load);
            this.ResumeLayout(false);

        }

        private void frmformatinuppercasehex_Load(object sender, EventArgs e)
        {

        }
    }
}
