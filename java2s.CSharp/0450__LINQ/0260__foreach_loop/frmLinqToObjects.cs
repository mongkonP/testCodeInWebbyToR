using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0260__foreach_loop
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/LinqToObjects.htm
    public partial  class frmLinqToObjects:Form
    {
        public frmLinqToObjects()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLinqToObjects
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLinqToObjects";
            this.Text = "frmLinqToObjects";
            this.Load += new System.EventHandler(this.frmLinqToObjects_Load);
            this.ResumeLayout(false);

        }

        private void frmLinqToObjects_Load(object sender, EventArgs e)
        {

        }
    }
}
