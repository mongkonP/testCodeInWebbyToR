using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1621__DataGridView
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SimpleDataGridView.htm
    public partial  class frmSimpleDataGridView:Form
    {
        public frmSimpleDataGridView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleDataGridView
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleDataGridView";
            this.Text = "frmSimpleDataGridView";
            this.Load += new System.EventHandler(this.frmSimpleDataGridView_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleDataGridView_Load(object sender, EventArgs e)
        {

        }
    }
}
