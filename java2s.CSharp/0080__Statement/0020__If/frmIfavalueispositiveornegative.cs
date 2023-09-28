using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0020__If
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Ifavalueispositiveornegative.htm
    public partial  class frmIfavalueispositiveornegative:Form
    {
        public frmIfavalueispositiveornegative()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIfavalueispositiveornegative
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIfavalueispositiveornegative";
            this.Text = "frmIfavalueispositiveornegative";
            this.Load += new System.EventHandler(this.frmIfavalueispositiveornegative_Load);
            this.ResumeLayout(false);

        }

        private void frmIfavalueispositiveornegative_Load(object sender, EventArgs e)
        {

        }
    }
}
