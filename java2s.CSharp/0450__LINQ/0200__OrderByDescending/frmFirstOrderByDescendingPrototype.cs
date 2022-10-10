using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0200__OrderByDescending
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/FirstOrderByDescendingPrototype.htm
    public partial  class frmFirstOrderByDescendingPrototype:Form
    {
        public frmFirstOrderByDescendingPrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFirstOrderByDescendingPrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFirstOrderByDescendingPrototype";
            this.Text = "frmFirstOrderByDescendingPrototype";
            this.Load += new System.EventHandler(this.frmFirstOrderByDescendingPrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmFirstOrderByDescendingPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
