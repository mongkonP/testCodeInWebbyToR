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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FillColumns.htm
    public partial  class frmFillColumns:Form
    {
        public frmFillColumns()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFillColumns
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFillColumns";
            this.Text = "frmFillColumns";
            this.Load += new System.EventHandler(this.frmFillColumns_Load);
            this.ResumeLayout(false);

        }

        private void frmFillColumns_Load(object sender, EventArgs e)
        {

        }
    }
}
