using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0070__Let
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SimpleLetExample.htm
    public partial  class frmSimpleLetExample:Form
    {
        public frmSimpleLetExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleLetExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleLetExample";
            this.Text = "frmSimpleLetExample";
            this.Load += new System.EventHandler(this.frmSimpleLetExample_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleLetExample_Load(object sender, EventArgs e)
        {

        }
    }
}
