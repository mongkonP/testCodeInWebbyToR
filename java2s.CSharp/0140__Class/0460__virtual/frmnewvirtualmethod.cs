using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0460__virtual
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/newvirtualmethod.htm
    public partial  class frmnewvirtualmethod:Form
    {
        public frmnewvirtualmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmnewvirtualmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmnewvirtualmethod";
            this.Text = "frmnewvirtualmethod";
            this.Load += new System.EventHandler(this.frmnewvirtualmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmnewvirtualmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
