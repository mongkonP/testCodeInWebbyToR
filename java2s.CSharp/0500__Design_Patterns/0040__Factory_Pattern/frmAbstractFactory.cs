using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0040__Factory_Pattern
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/AbstractFactory.htm
    public partial  class frmAbstractFactory:Form
    {
        public frmAbstractFactory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAbstractFactory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAbstractFactory";
            this.Text = "frmAbstractFactory";
            this.Load += new System.EventHandler(this.frmAbstractFactory_Load);
            this.ResumeLayout(false);

        }

        private void frmAbstractFactory_Load(object sender, EventArgs e)
        {

        }
    }
}
