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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Overridevirtualfunctions.htm
    public partial  class frmOverridevirtualfunctions:Form
    {
        public frmOverridevirtualfunctions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverridevirtualfunctions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverridevirtualfunctions";
            this.Text = "frmOverridevirtualfunctions";
            this.Load += new System.EventHandler(this.frmOverridevirtualfunctions_Load);
            this.ResumeLayout(false);

        }

        private void frmOverridevirtualfunctions_Load(object sender, EventArgs e)
        {

        }
    }
}
