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
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/prefixincrement.htm
    public partial  class frmprefixincrement:Form
    {
        public frmprefixincrement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmprefixincrement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmprefixincrement";
            this.Text = "frmprefixincrement";
            this.Load += new System.EventHandler(this.frmprefixincrement_Load);
            this.ResumeLayout(false);

        }

        private void frmprefixincrement_Load(object sender, EventArgs e)
        {

        }
    }
}
