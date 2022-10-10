using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1360__SkipWhile
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SkipWhilePrototype.htm
    public partial  class frmSkipWhilePrototype:Form
    {
        public frmSkipWhilePrototype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSkipWhilePrototype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSkipWhilePrototype";
            this.Text = "frmSkipWhilePrototype";
            this.Load += new System.EventHandler(this.frmSkipWhilePrototype_Load);
            this.ResumeLayout(false);

        }

        private void frmSkipWhilePrototype_Load(object sender, EventArgs e)
        {

        }
    }
}
