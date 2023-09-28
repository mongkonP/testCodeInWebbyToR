using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0480__override
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/newmethodnotoverride.htm
    public partial  class frmnewmethodnotoverride:Form
    {
        public frmnewmethodnotoverride()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmnewmethodnotoverride
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmnewmethodnotoverride";
            this.Text = "frmnewmethodnotoverride";
            this.Load += new System.EventHandler(this.frmnewmethodnotoverride_Load);
            this.ResumeLayout(false);

        }

        private void frmnewmethodnotoverride_Load(object sender, EventArgs e)
        {

        }
    }
}
