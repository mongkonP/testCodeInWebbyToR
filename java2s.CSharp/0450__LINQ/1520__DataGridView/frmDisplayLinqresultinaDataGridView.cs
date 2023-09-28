using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1520__DataGridView
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/DisplayLinqresultinaDataGridView.htm
    public partial  class frmDisplayLinqresultinaDataGridView:Form
    {
        public frmDisplayLinqresultinaDataGridView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayLinqresultinaDataGridView
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayLinqresultinaDataGridView";
            this.Text = "frmDisplayLinqresultinaDataGridView";
            this.Load += new System.EventHandler(this.frmDisplayLinqresultinaDataGridView_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayLinqresultinaDataGridView_Load(object sender, EventArgs e)
        {

        }
    }
}
