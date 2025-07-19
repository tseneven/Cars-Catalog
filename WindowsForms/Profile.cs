using Classes;
using WindowsForms.Repositorys.Catalog;
using WindowsForms.Repositorys.User;

namespace WindowsForms
{
    public partial class Profile : Form
    {
        int UserId;
        string name;
        string telephone;
        bool isEdit = false;
        List<Car_Model> cars;



        IUser_Repository _user_Repository = new User_Repository();
        ICatalog_Repository _catalog_Repository = new Catalog_Repository();
        public Profile(int id)
        {
            InitializeComponent();
            this.UserId = id;
        }

        private async void Profile_Load(object sender, EventArgs e)
        {
            await GetUser();
            await GetUserCars(UserId);
        }

        private async Task GetUser()
        {
            User_Model user_Model = await _user_Repository.GetUser(UserId);

            name = user_Model.Name;
            telephone = user_Model.telephone;

            textBox1.Text = name;
            textBox2.Text = telephone;
        }

        private async Task GetUserCars(int id)
        {
            cars = await _catalog_Repository.GetUserCars(id);

            listBox1.Items.Clear();

            for (int i = 0; i < cars.Count; i++)
            {
                listBox1.Items.Add(cars[i].Name);
            }
        }

        public async Task Edit()
        {
            User_Model user_Model = new User_Model
            {
                Id = UserId,
                Name = textBox1.Text,
                telephone = textBox2.Text
            };

            await _user_Repository.Edit(user_Model);
        }

        private void Profile_Edit_Button_Click(object sender, EventArgs e)
        {
        }

        private async void Profile_Edit_Button_Click_1(object sender, EventArgs e)
        {
            if (isEdit)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                isEdit = false;
                Profile_Edit_Button.Text = "Редактировать";

                //Функция сохранения

                await Edit();


            }
            else
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                isEdit = true;
                Profile_Edit_Button.Text = "Сохранить";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar(UserId);
            addCar.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int SelectedIndexAuto = listBox1.SelectedIndex;

            if (SelectedIndexAuto == -1)
            {
                MessageBox.Show("Автомобиль не выбран");
            }
            else
            {
                await _catalog_Repository.DeleteCar(cars[SelectedIndexAuto].ID);
                await GetUserCars(UserId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SelectedIndexAuto = listBox1.SelectedIndex;

            if (SelectedIndexAuto == -1)
            {
                MessageBox.Show("Автомобиль не выбран");
            }
            else
            {
                AddCar addCar = new AddCar(UserId, cars[SelectedIndexAuto]);
                addCar.Show();

            }

        }

        private void Profile_Delete_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить аккаунт?", "Удаление аккаунта", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _user_Repository.Delete(UserId);
                this.Hide();
                Auth_Register auth = new Auth_Register();
                auth.Show();
            }
        }
    }
}
