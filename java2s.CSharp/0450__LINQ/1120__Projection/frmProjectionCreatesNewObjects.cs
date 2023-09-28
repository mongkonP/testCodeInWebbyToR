using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1120__Projection
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ProjectionCreatesNewObjects.htm
    public partial  class frmProjectionCreatesNewObjects:Form
    {
        public frmProjectionCreatesNewObjects()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProjectionCreatesNewObjects
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProjectionCreatesNewObjects";
            this.Text = "frmProjectionCreatesNewObjects";
            this.Load += new System.EventHandler(this.frmProjectionCreatesNewObjects_Load);
            this.ResumeLayout(false);

        }

        private void frmProjectionCreatesNewObjects_Load(object sender, EventArgs e)
        {

        }
    }
}
