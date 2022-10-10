using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0320__SecureString
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/InstantiatesanewSecureStringobjectbypassingitsconstructorapointertoacharacterarray.htm
    public partial  class frmInstantiatesanewSecureStringobjectbypassingitsconstructorapointertoacharacterarray:Form
    {
        public frmInstantiatesanewSecureStringobjectbypassingitsconstructorapointertoacharacterarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInstantiatesanewSecureStringobjectbypassingitsconstructorapointertoacharacterarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInstantiatesanewSecureStringobjectbypassingitsconstructorapointertoacharacterarray";
            this.Text = "frmInstantiatesanewSecureStringobjectbypassingitsconstructorapointertoacharacterarray";
            this.Load += new System.EventHandler(this.frmInstantiatesanewSecureStringobjectbypassingitsconstructorapointertoacharacterarray_Load);
            this.ResumeLayout(false);

        }

        private void frmInstantiatesanewSecureStringobjectbypassingitsconstructorapointertoacharacterarray_Load(object sender, EventArgs e)
        {

        }
    }
}
