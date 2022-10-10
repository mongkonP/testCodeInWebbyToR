using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1000__Last
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/LastPrototype.htm
    public partial  class frmLastPrototype:Form
    {
        public frmLastPrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLastPrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLastPrototype";
            this.Text = "frmLastPrototype";
            this.Load += new System.EventHandler(this.frmLastPrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmLastPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
