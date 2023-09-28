using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0180__OrderBy
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/FirstOrderByPrototype.htm
    public partial  class frmFirstOrderByPrototype:Form
    {
        public frmFirstOrderByPrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFirstOrderByPrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFirstOrderByPrototype";
            this.Text = "frmFirstOrderByPrototype";
            this.Load += new System.EventHandler(this.frmFirstOrderByPrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmFirstOrderByPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
