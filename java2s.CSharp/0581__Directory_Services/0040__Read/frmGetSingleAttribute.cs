using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0040__Read
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/GetSingleAttribute.htm
    public partial  class frmGetSingleAttribute:Form
    {
        public frmGetSingleAttribute()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetSingleAttribute
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetSingleAttribute";
            this.Text = "frmGetSingleAttribute";
            this.Load += new System.EventHandler(this.frmGetSingleAttribute_Load);
            this.ResumeLayout(false);

        }

        private void frmGetSingleAttribute_Load(object sender, EventArgs e)
        {

        }
    }
}
