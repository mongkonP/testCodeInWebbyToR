using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0760__Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/PropertiesanditsRestrictions.htm
    public partial  class frmPropertiesanditsRestrictions:Form
    {
        public frmPropertiesanditsRestrictions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPropertiesanditsRestrictions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPropertiesanditsRestrictions";
            this.Text = "frmPropertiesanditsRestrictions";
            this.Load += new System.EventHandler(this.frmPropertiesanditsRestrictions_Load);
            this.ResumeLayout(false);

        }

        private void frmPropertiesanditsRestrictions_Load(object sender, EventArgs e)
        {

        }
    }
}
