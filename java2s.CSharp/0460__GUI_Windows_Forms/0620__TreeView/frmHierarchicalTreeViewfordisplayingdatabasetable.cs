using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0620__TreeView
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/HierarchicalTreeViewfordisplayingdatabasetable.htm
    public partial  class frmHierarchicalTreeViewfordisplayingdatabasetable:Form
    {
        public frmHierarchicalTreeViewfordisplayingdatabasetable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHierarchicalTreeViewfordisplayingdatabasetable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHierarchicalTreeViewfordisplayingdatabasetable";
            this.Text = "frmHierarchicalTreeViewfordisplayingdatabasetable";
            this.Load += new System.EventHandler(this.frmHierarchicalTreeViewfordisplayingdatabasetable_Load);
            this.ResumeLayout(false);

        }

        private void frmHierarchicalTreeViewfordisplayingdatabasetable_Load(object sender, EventArgs e)
        {

        }
    }
}
