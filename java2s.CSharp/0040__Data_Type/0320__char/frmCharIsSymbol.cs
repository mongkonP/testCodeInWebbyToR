using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0320__char
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/CharIsSymbol.htm
    public partial  class frmCharIsSymbol:Form
    {
        public frmCharIsSymbol()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCharIsSymbol
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCharIsSymbol";
            this.Text = "frmCharIsSymbol";
            this.Load += new System.EventHandler(this.frmCharIsSymbol_Load);
            this.ResumeLayout(false);

        }

        private void frmCharIsSymbol_Load(object sender, EventArgs e)
        {

        }
    }
}
