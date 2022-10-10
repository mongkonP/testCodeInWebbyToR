using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1260__SelectMany
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SelectManyPrototype.htm
    public partial  class frmSelectManyPrototype:Form
    {
        public frmSelectManyPrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectManyPrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectManyPrototype";
            this.Text = "frmSelectManyPrototype";
            this.Load += new System.EventHandler(this.frmSelectManyPrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectManyPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
