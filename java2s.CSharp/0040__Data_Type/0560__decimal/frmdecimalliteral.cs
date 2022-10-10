using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0560__decimal
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/decimalliteral.htm
    public partial  class frmdecimalliteral:Form
    {
        public frmdecimalliteral()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmdecimalliteral
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmdecimalliteral";
            this.Text = "frmdecimalliteral";
            this.Load += new System.EventHandler(this.frmdecimalliteral_Load);
            this.ResumeLayout(false);

        }

        private void frmdecimalliteral_Load(object sender, EventArgs e)
        {

        }
    }
}
