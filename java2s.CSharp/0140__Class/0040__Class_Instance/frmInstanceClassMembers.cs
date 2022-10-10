using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0040__Class_Instance
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/InstanceClassMembers.htm
    public partial  class frmInstanceClassMembers:Form
    {
        public frmInstanceClassMembers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInstanceClassMembers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInstanceClassMembers";
            this.Text = "frmInstanceClassMembers";
            this.Load += new System.EventHandler(this.frmInstanceClassMembers_Load);
            this.ResumeLayout(false);

        }

        private void frmInstanceClassMembers_Load(object sender, EventArgs e)
        {

        }
    }
}
