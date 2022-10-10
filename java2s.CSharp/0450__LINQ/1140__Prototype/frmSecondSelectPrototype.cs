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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SecondSelectPrototype.htm
    public partial  class frmSecondSelectPrototype:Form
    {
        public frmSecondSelectPrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSecondSelectPrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSecondSelectPrototype";
            this.Text = "frmSecondSelectPrototype";
            this.Load += new System.EventHandler(this.frmSecondSelectPrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmSecondSelectPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
