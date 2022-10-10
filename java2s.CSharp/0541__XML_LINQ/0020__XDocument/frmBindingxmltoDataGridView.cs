using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0541__XML_LINQ.C0020__XDocument
{
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/BindingxmltoDataGridView.htm
    public partial  class frmBindingxmltoDataGridView:Form
    {
        public frmBindingxmltoDataGridView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindingxmltoDataGridView
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindingxmltoDataGridView";
            this.Text = "frmBindingxmltoDataGridView";
            this.Load += new System.EventHandler(this.frmBindingxmltoDataGridView_Load);
            this.ResumeLayout(false);

        }

        private void frmBindingxmltoDataGridView_Load(object sender, EventArgs e)
        {

        }
    }
}
