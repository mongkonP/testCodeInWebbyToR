using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0260__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Privatecopyconstructorusedwhenmakingacopyofthisobject.htm
    public partial  class frmPrivatecopyconstructorusedwhenmakingacopyofthisobject:Form
    {
        public frmPrivatecopyconstructorusedwhenmakingacopyofthisobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrivatecopyconstructorusedwhenmakingacopyofthisobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrivatecopyconstructorusedwhenmakingacopyofthisobject";
            this.Text = "frmPrivatecopyconstructorusedwhenmakingacopyofthisobject";
            this.Load += new System.EventHandler(this.frmPrivatecopyconstructorusedwhenmakingacopyofthisobject_Load);
            this.ResumeLayout(false);

        }

        private void frmPrivatecopyconstructorusedwhenmakingacopyofthisobject_Load(object sender, EventArgs e)
        {

        }
    }
}
