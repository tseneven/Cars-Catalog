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
    public partial class AddCar : Form
    {
        int UserID;
        bool isEdit;
        Car_Model car;
        ICatalog_Repository _catalog_Repository = new Catalog_Repository();

        public AddCar(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }

        public AddCar(int UserID, Car_Model car)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.car = car;
            isEdit = true;
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            if (isEdit == true) 
            {
                Name_TextBox.Text = car.Name;
                Years_TextBox.Text = car.Years;
                Mileage_TtextBox.Text = car.Mileage;
                Technical_Сondition_TextBox.Text = car.Technical_Сondition;
                Price_TextBox.Text = car.Price;
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (isEdit == false)
            {
                Car_Model car_Model = new Car_Model
                {
                    UserID = this.UserID,
                    Name = Name_TextBox.Text,
                    Years = Years_TextBox.Text,
                    Mileage = Mileage_TtextBox.Text,
                    Technical_Сondition = Technical_Сondition_TextBox.Text,
                    image = null,
                    Price = Price_TextBox.Text
                };


                _catalog_Repository.AddCar(car_Model);
            }
            else if (isEdit == true) 
            {
                Car_Model car_Model = new Car_Model
                {
                    UserID = this.UserID,
                    Name = Name_TextBox.Text,
                    Years = Years_TextBox.Text,
                    Mileage = Mileage_TtextBox.Text,
                    Technical_Сondition = Technical_Сondition_TextBox.Text,
                    image = null,
                    Price = Price_TextBox.Text
                };

                _catalog_Repository.EditCar(car_Model);

            }
        }
    }
}
