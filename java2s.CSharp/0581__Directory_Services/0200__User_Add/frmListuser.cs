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
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/Listuser.htm
    public partial  class frmListuser:Form
    {
        public frmListuser()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListuser
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListuser";
            this.Text = "frmListuser";
            this.Load += new System.EventHandler(this.frmListuser_Load);
            this.ResumeLayout(false);

        }

        private void frmListuser_Load(object sender, EventArgs e)
        {

        }
    }
}
