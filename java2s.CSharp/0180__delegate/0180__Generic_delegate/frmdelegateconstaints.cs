using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0180__Generic_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/delegateconstaints.htm
    public partial  class frmdelegateconstaints:Form
    {
        public frmdelegateconstaints()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmdelegateconstaints
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmdelegateconstaints";
            this.Text = "frmdelegateconstaints";
            this.Load += new System.EventHandler(this.frmdelegateconstaints_Load);
            this.ResumeLayout(false);

        }

        private void frmdelegateconstaints_Load(object sender, EventArgs e)
        {

        }
    }
}
