using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0120__Method_Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/useofoutervariableinanonymousmethod.htm
    public partial  class frmuseofoutervariableinanonymousmethod:Form
    {
        public frmuseofoutervariableinanonymousmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmuseofoutervariableinanonymousmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmuseofoutervariableinanonymousmethod";
            this.Text = "frmuseofoutervariableinanonymousmethod";
            this.Load += new System.EventHandler(this.frmuseofoutervariableinanonymousmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmuseofoutervariableinanonymousmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
