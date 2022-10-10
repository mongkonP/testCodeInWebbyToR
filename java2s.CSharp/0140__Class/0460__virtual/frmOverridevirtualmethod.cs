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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Overridevirtualmethod.htm
    public partial  class frmOverridevirtualmethod:Form
    {
        public frmOverridevirtualmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverridevirtualmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverridevirtualmethod";
            this.Text = "frmOverridevirtualmethod";
            this.Load += new System.EventHandler(this.frmOverridevirtualmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmOverridevirtualmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
