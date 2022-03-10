using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_Sample.Views;
using MVP_Sample.Presenters;
namespace MVP_Sample
{
    public partial class Form1 : Form,IRectangle
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string LengthTest
        {
            get { return tb_length.Text;}
            set { tb_length.Text = value; }
        }

        public string BreadthText
        {
            get
            {
                return tb_breadth.Text;
            }
            set
            {
                tb_breadth.Text = value;
            }
        }

        public string AreaText
        {
            get
            {
                return tb_area.Text;
            }
            set
            {
                tb_area.Text = value;
            }
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.CalculateArea();
        }
    }
}
