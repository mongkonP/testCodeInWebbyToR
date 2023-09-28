using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0220__Xml_Node
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/Insertafter.htm
    public partial  class frmInsertafter:Form
    {
        public frmInsertafter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInsertafter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInsertafter";
            this.Text = "frmInsertafter";
            this.Load += new System.EventHandler(this.frmInsertafter_Load);
            this.ResumeLayout(false);

        }

        private void frmInsertafter_Load(object sender, EventArgs e)
        {

        }
    }
}
