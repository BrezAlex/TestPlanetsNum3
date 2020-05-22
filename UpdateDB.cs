using System.Windows.Forms;
using System.Data.Entity;

namespace TestPlanetsNum3
{
    public partial class UpdateDB : Form
    {
        PlanetsContext db;
        public UpdateDB()
        {
            InitializeComponent();
            db = new PlanetsContext();
            db.Planets.Load();
            dataGridView1.DataSource = db.Planets.Local.ToBindingList();
        }
    }
}
