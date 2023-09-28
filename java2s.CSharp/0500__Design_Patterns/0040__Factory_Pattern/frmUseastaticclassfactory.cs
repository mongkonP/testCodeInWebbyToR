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
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/Useastaticclassfactory.htm
    public partial  class frmUseastaticclassfactory:Form
    {
        public frmUseastaticclassfactory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseastaticclassfactory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseastaticclassfactory";
            this.Text = "frmUseastaticclassfactory";
            this.Load += new System.EventHandler(this.frmUseastaticclassfactory_Load);
            this.ResumeLayout(false);

        }

        private void frmUseastaticclassfactory_Load(object sender, EventArgs e)
        {

        }
    }
}
