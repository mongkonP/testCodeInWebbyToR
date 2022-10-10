using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1140__Prototype
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/FirstSelectPrototype.htm
    public partial  class frmFirstSelectPrototype:Form
    {
        public frmFirstSelectPrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFirstSelectPrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFirstSelectPrototype";
            this.Text = "frmFirstSelectPrototype";
            this.Load += new System.EventHandler(this.frmFirstSelectPrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmFirstSelectPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
