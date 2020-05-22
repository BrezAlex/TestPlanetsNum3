using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestPlanetsNum3
{
    public partial class Form1 : Form
    {
        private double _m;
        private double _r;
        private double _h;
        private const double G = 6.67e-11;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var UDB = new UpdateDB(); //
            UDB.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            comboBox1.DataSource = GetDP();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private List<Planets> GetDP()
        {
            using (var db = new PlanetsContext())
            {
                var planets = db.Planets.ToList();
                return planets;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var planets = GetDP();
            var id = int.Parse(comboBox1.SelectedValue.ToString());
            _h = double.Parse(textBox3.Text);
            _m = planets.FirstOrDefault(f => f.Id == id).M;
            _r = planets.FirstOrDefault(f => f.Id == id).R;
        }

        private (double, double) Calc()
        {
            var v1 = Math.Sqrt((G*_m)/(_r+_h));
            var v2 = Math.Sqrt(2)*v1;
            return (v1, v2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Calc().Item1.ToString();
            textBox2.Text = Calc().Item2.ToString();
        }
    }
}
