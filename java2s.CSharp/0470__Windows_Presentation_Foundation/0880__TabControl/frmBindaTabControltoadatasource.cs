using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0880__TabControl
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindaTabControltoadatasource.htm
    public partial  class frmBindaTabControltoadatasource:Form
    {
        public frmBindaTabControltoadatasource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindaTabControltoadatasource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindaTabControltoadatasource";
            this.Text = "frmBindaTabControltoadatasource";
            this.Load += new System.EventHandler(this.frmBindaTabControltoadatasource_Load);
            this.ResumeLayout(false);

        }

        private void frmBindaTabControltoadatasource_Load(object sender, EventArgs e)
        {

        }
    }
}
