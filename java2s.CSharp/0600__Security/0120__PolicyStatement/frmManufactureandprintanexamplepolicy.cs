using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0120__PolicyStatement
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Manufactureandprintanexamplepolicy.htm
    public partial  class frmManufactureandprintanexamplepolicy:Form
    {
        public frmManufactureandprintanexamplepolicy()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmManufactureandprintanexamplepolicy
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmManufactureandprintanexamplepolicy";
            this.Text = "frmManufactureandprintanexamplepolicy";
            this.Load += new System.EventHandler(this.frmManufactureandprintanexamplepolicy_Load);
            this.ResumeLayout(false);

        }

        private void frmManufactureandprintanexamplepolicy_Load(object sender, EventArgs e)
        {

        }
    }
}
