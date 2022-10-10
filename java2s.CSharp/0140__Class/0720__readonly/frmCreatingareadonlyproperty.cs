using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0720__readonly
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Creatingareadonlyproperty.htm
    public partial  class frmCreatingareadonlyproperty:Form
    {
        public frmCreatingareadonlyproperty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingareadonlyproperty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingareadonlyproperty";
            this.Text = "frmCreatingareadonlyproperty";
            this.Load += new System.EventHandler(this.frmCreatingareadonlyproperty_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingareadonlyproperty_Load(object sender, EventArgs e)
        {

        }
    }
}
