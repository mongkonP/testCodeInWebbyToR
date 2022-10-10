using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0420__MutexSecurity
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Addarulethatallowsthecurrentusertherighttoreadpermissionsonthemutex.htm
    public partial  class frmAddarulethatallowsthecurrentusertherighttoreadpermissionsonthemutex:Form
    {
        public frmAddarulethatallowsthecurrentusertherighttoreadpermissionsonthemutex()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddarulethatallowsthecurrentusertherighttoreadpermissionsonthemutex
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddarulethatallowsthecurrentusertherighttoreadpermissionsonthemutex";
            this.Text = "frmAddarulethatallowsthecurrentusertherighttoreadpermissionsonthemutex";
            this.Load += new System.EventHandler(this.frmAddarulethatallowsthecurrentusertherighttoreadpermissionsonthemutex_Load);
            this.ResumeLayout(false);

        }

        private void frmAddarulethatallowsthecurrentusertherighttoreadpermissionsonthemutex_Load(object sender, EventArgs e)
        {

        }
    }
}
