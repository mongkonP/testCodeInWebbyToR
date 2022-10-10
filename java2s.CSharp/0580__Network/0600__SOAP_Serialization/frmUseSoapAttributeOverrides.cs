using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0600__SOAP_Serialization
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UseSoapAttributeOverrides.htm
    public partial  class frmUseSoapAttributeOverrides:Form
    {
        public frmUseSoapAttributeOverrides()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseSoapAttributeOverrides
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseSoapAttributeOverrides";
            this.Text = "frmUseSoapAttributeOverrides";
            this.Load += new System.EventHandler(this.frmUseSoapAttributeOverrides_Load);
            this.ResumeLayout(false);

        }

        private void frmUseSoapAttributeOverrides_Load(object sender, EventArgs e)
        {

        }
    }
}
