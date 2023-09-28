using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0400__Class_hierarchy
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Asimpleclasshierarchy.htm
    public partial  class frmAsimpleclasshierarchy:Form
    {
        public frmAsimpleclasshierarchy()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsimpleclasshierarchy
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsimpleclasshierarchy";
            this.Text = "frmAsimpleclasshierarchy";
            this.Load += new System.EventHandler(this.frmAsimpleclasshierarchy_Load);
            this.ResumeLayout(false);

        }

        private void frmAsimpleclasshierarchy_Load(object sender, EventArgs e)
        {

        }
    }
}
