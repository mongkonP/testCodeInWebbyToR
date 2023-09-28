using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0060__Prefix_Postfix_Operator
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/prefixdecrement.htm
    public partial  class frmprefixdecrement:Form
    {
        public frmprefixdecrement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmprefixdecrement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmprefixdecrement";
            this.Text = "frmprefixdecrement";
            this.Load += new System.EventHandler(this.frmprefixdecrement_Load);
            this.ResumeLayout(false);

        }

        private void frmprefixdecrement_Load(object sender, EventArgs e)
        {

        }
    }
}
