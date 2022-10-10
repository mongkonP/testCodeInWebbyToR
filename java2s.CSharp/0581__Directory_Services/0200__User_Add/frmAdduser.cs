using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0200__User_Add
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/Adduser.htm
    public partial  class frmAdduser:Form
    {
        public frmAdduser()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAdduser
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAdduser";
            this.Text = "frmAdduser";
            this.Load += new System.EventHandler(this.frmAdduser_Load);
            this.ResumeLayout(false);

        }

        private void frmAdduser_Load(object sender, EventArgs e)
        {

        }
    }
}
