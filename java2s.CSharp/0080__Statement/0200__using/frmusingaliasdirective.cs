using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0200__using
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/usingaliasdirective.htm
    public partial  class frmusingaliasdirective:Form
    {
        public frmusingaliasdirective()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmusingaliasdirective
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmusingaliasdirective";
            this.Text = "frmusingaliasdirective";
            this.Load += new System.EventHandler(this.frmusingaliasdirective_Load);
            this.ResumeLayout(false);

        }

        private void frmusingaliasdirective_Load(object sender, EventArgs e)
        {

        }
    }
}
