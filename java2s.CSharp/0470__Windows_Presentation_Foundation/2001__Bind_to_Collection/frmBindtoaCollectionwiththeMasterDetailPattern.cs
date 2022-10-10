using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2001__Bind_to_Collection
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindtoaCollectionwiththeMasterDetailPattern.htm
    public partial  class frmBindtoaCollectionwiththeMasterDetailPattern:Form
    {
        public frmBindtoaCollectionwiththeMasterDetailPattern()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindtoaCollectionwiththeMasterDetailPattern
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindtoaCollectionwiththeMasterDetailPattern";
            this.Text = "frmBindtoaCollectionwiththeMasterDetailPattern";
            this.Load += new System.EventHandler(this.frmBindtoaCollectionwiththeMasterDetailPattern_Load);
            this.ResumeLayout(false);

        }

        private void frmBindtoaCollectionwiththeMasterDetailPattern_Load(object sender, EventArgs e)
        {

        }
    }
}
