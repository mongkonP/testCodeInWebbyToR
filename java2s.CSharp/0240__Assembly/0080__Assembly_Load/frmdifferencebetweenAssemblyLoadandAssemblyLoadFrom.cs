using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0080__Assembly_Load
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/differencebetweenAssemblyLoadandAssemblyLoadFrom.htm
    public partial  class frmdifferencebetweenAssemblyLoadandAssemblyLoadFrom:Form
    {
        public frmdifferencebetweenAssemblyLoadandAssemblyLoadFrom()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmdifferencebetweenAssemblyLoadandAssemblyLoadFrom
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmdifferencebetweenAssemblyLoadandAssemblyLoadFrom";
            this.Text = "frmdifferencebetweenAssemblyLoadandAssemblyLoadFrom";
            this.Load += new System.EventHandler(this.frmdifferencebetweenAssemblyLoadandAssemblyLoadFrom_Load);
            this.ResumeLayout(false);

        }

        private void frmdifferencebetweenAssemblyLoadandAssemblyLoadFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
