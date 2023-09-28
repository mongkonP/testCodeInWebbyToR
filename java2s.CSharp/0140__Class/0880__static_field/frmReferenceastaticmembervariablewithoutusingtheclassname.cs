using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0880__static_field
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Referenceastaticmembervariablewithoutusingtheclassname.htm
    public partial  class frmReferenceastaticmembervariablewithoutusingtheclassname:Form
    {
        public frmReferenceastaticmembervariablewithoutusingtheclassname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReferenceastaticmembervariablewithoutusingtheclassname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReferenceastaticmembervariablewithoutusingtheclassname";
            this.Text = "frmReferenceastaticmembervariablewithoutusingtheclassname";
            this.Load += new System.EventHandler(this.frmReferenceastaticmembervariablewithoutusingtheclassname_Load);
            this.ResumeLayout(false);

        }

        private void frmReferenceastaticmembervariablewithoutusingtheclassname_Load(object sender, EventArgs e)
        {

        }
    }
}
