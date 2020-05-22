using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestPlanetsNum3
{
    public partial class Form1 : Form
    {
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
    }
}
