using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0040__Class_Instance
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Creatinganarrayofobjects.htm
    public partial  class frmCreatinganarrayofobjects:Form
    {
        public frmCreatinganarrayofobjects()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatinganarrayofobjects
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatinganarrayofobjects";
            this.Text = "frmCreatinganarrayofobjects";
            this.Load += new System.EventHandler(this.frmCreatinganarrayofobjects_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatinganarrayofobjects_Load(object sender, EventArgs e)
        {

        }
    }
}
