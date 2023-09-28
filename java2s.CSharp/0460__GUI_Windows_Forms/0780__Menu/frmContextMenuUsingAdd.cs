using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0780__Menu
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ContextMenuUsingAdd.htm
    public partial  class frmContextMenuUsingAdd:Form
    {
        public frmContextMenuUsingAdd()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmContextMenuUsingAdd
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmContextMenuUsingAdd";
            this.Text = "frmContextMenuUsingAdd";
            this.Load += new System.EventHandler(this.frmContextMenuUsingAdd_Load);
            this.ResumeLayout(false);

        }

        private void frmContextMenuUsingAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
