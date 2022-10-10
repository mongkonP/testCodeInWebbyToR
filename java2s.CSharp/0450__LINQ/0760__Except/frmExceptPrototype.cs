using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0760__Except
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ExceptPrototype.htm
    public partial  class frmExceptPrototype:Form
    {
        public frmExceptPrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExceptPrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExceptPrototype";
            this.Text = "frmExceptPrototype";
            this.Load += new System.EventHandler(this.frmExceptPrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmExceptPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
