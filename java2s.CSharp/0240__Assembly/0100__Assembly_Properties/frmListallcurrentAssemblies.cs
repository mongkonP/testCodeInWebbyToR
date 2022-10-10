using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0100__Assembly_Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/ListallcurrentAssemblies.htm
    public partial  class frmListallcurrentAssemblies:Form
    {
        public frmListallcurrentAssemblies()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListallcurrentAssemblies
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListallcurrentAssemblies";
            this.Text = "frmListallcurrentAssemblies";
            this.Load += new System.EventHandler(this.frmListallcurrentAssemblies_Load);
            this.ResumeLayout(false);

        }

        private void frmListallcurrentAssemblies_Load(object sender, EventArgs e)
        {

        }
    }
}
