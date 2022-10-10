using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0021__Attributes
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/GetCustomAttributes.htm
    public partial  class frmGetCustomAttributes:Form
    {
        public frmGetCustomAttributes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetCustomAttributes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetCustomAttributes";
            this.Text = "frmGetCustomAttributes";
            this.Load += new System.EventHandler(this.frmGetCustomAttributes_Load);
            this.ResumeLayout(false);

        }

        private void frmGetCustomAttributes_Load(object sender, EventArgs e)
        {

        }
    }
}
