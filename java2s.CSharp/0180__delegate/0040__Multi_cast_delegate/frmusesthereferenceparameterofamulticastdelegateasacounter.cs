using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0040__Multi_cast_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/usesthereferenceparameterofamulticastdelegateasacounter.htm
    public partial  class frmusesthereferenceparameterofamulticastdelegateasacounter:Form
    {
        public frmusesthereferenceparameterofamulticastdelegateasacounter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmusesthereferenceparameterofamulticastdelegateasacounter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmusesthereferenceparameterofamulticastdelegateasacounter";
            this.Text = "frmusesthereferenceparameterofamulticastdelegateasacounter";
            this.Load += new System.EventHandler(this.frmusesthereferenceparameterofamulticastdelegateasacounter_Load);
            this.ResumeLayout(false);

        }

        private void frmusesthereferenceparameterofamulticastdelegateasacounter_Load(object sender, EventArgs e)
        {

        }
    }
}
