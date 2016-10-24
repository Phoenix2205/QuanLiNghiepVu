using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNghiepVu
{
    public partial class form_main : Form
    {
        bool isClosed = true;
        public form_main()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (isClosed)
            {
                panel1.Location = new Point(-299, 2);
                do
                {
                    panel1.Location = new Point(panel1.Location.X + 1, 0);
                    Refresh();

                } while (panel1.Location.X != 1);
                isClosed = false;
            }
            else
            {
                panel1.Location = new Point(1, 2);
                do
                {
                    panel1.Location = new Point(panel1.Location.X - 1, 0);
                    Refresh();

                } while (panel1.Location.X != -299);
                isClosed = true;
            }
        }

       
    }
}
