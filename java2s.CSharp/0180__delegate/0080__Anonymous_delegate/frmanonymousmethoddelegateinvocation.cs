using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0080__Anonymous_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/anonymousmethoddelegateinvocation.htm
    public partial  class frmanonymousmethoddelegateinvocation:Form
    {
        public frmanonymousmethoddelegateinvocation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmanonymousmethoddelegateinvocation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmanonymousmethoddelegateinvocation";
            this.Text = "frmanonymousmethoddelegateinvocation";
            this.Load += new System.EventHandler(this.frmanonymousmethoddelegateinvocation_Load);
            this.ResumeLayout(false);

        }

        private void frmanonymousmethoddelegateinvocation_Load(object sender, EventArgs e)
        {

        }
    }
}
