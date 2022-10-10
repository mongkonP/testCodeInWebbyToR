using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0080__Xml_Read
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SetBookAsCurrent.htm
    public partial  class frmSetBookAsCurrent:Form
    {
        public frmSetBookAsCurrent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetBookAsCurrent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetBookAsCurrent";
            this.Text = "frmSetBookAsCurrent";
            this.Load += new System.EventHandler(this.frmSetBookAsCurrent_Load);
            this.ResumeLayout(false);

        }

        private void frmSetBookAsCurrent_Load(object sender, EventArgs e)
        {

        }
    }
}
