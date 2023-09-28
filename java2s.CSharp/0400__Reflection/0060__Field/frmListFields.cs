using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0060__Field
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/ListFields.htm
    public partial  class frmListFields:Form
    {
        public frmListFields()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListFields
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListFields";
            this.Text = "frmListFields";
            this.Load += new System.EventHandler(this.frmListFields_Load);
            this.ResumeLayout(false);

        }

        private void frmListFields_Load(object sender, EventArgs e)
        {

        }
    }
}
