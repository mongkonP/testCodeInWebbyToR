using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0240__Decorator_Pattern
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/Decoratorpattern.htm
    public partial  class frmDecoratorpattern:Form
    {
        public frmDecoratorpattern()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDecoratorpattern
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDecoratorpattern";
            this.Text = "frmDecoratorpattern";
            this.Load += new System.EventHandler(this.frmDecoratorpattern_Load);
            this.ResumeLayout(false);

        }

        private void frmDecoratorpattern_Load(object sender, EventArgs e)
        {

        }
    }
}
