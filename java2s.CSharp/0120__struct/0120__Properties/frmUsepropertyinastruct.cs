using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0120__Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Usepropertyinastruct.htm
    public partial  class frmUsepropertyinastruct:Form
    {
        public frmUsepropertyinastruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsepropertyinastruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsepropertyinastruct";
            this.Text = "frmUsepropertyinastruct";
            this.Load += new System.EventHandler(this.frmUsepropertyinastruct_Load);
            this.ResumeLayout(false);

        }

        private void frmUsepropertyinastruct_Load(object sender, EventArgs e)
        {

        }
    }
}
