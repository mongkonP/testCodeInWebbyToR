using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1080__Min
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/FirstMinPrototype.htm
    public partial  class frmFirstMinPrototype:Form
    {
        public frmFirstMinPrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFirstMinPrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFirstMinPrototype";
            this.Text = "frmFirstMinPrototype";
            this.Load += new System.EventHandler(this.frmFirstMinPrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmFirstMinPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
