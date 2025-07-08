using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Repositorys.Catalog;

namespace WindowsForms
{
    public partial class Catalog : Form
    {
        ICatalog_Repository catalog;
        List<Car_Model> car_Model;
        int UserID;

        public Catalog(int UserID)
        {
            InitializeComponent();
            catalog = new Catalog_Repository();
            this.UserID = UserID;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car_Model selectedCar = car_Model[listBox1.SelectedIndex];
            listBox2.Items.Clear();
            listBox2.Items.Add($"Название: {selectedCar.Name}");
            listBox2.Items.Add($"Год выпуска: {selectedCar.Years}");
            listBox2.Items.Add($"Пробег: {selectedCar.Mileage}");
            listBox2.Items.Add($"Состояние: {selectedCar.Technical_Сondition}");
            listBox2.Items.Add($"Цена: {selectedCar.Price}");
        }

        private async void Catalog_Load(object sender, EventArgs e)
        {
            car_Model = await catalog.GetAllCars();

            for (int i = 0; i < car_Model.Count; i++)
            {
                listBox1.Items.Add(car_Model[i].Name);
            }
        }
    }
}
