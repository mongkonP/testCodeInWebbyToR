using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1440__ThenBy
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/FirstThenByPrototype.htm
    public partial  class frmFirstThenByPrototype:Form
    {
        public frmFirstThenByPrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFirstThenByPrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFirstThenByPrototype";
            this.Text = "frmFirstThenByPrototype";
            this.Load += new System.EventHandler(this.frmFirstThenByPrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmFirstThenByPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
