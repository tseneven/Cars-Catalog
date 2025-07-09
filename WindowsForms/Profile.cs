using Classes;
using WindowsForms.Repositorys.User;

namespace WindowsForms
{
    public partial class Profile : Form
    {
        int id;
        string name;
        string telephone;
        bool isEdit = false;


        IUser_Repository _user_Repository = new User_Repository();
        public Profile(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private async void Profile_Load(object sender, EventArgs e)
        {
            User_Model user_Model = await _user_Repository.GetUser(id);

            name = user_Model.Name;
            telephone = user_Model.telephone;

            textBox1.Text = name;
            textBox2.Text = telephone;
        }

        private void Profile_Edit_Button_Click(object sender, EventArgs e)
        {
        }

        private void Profile_Edit_Button_Click_1(object sender, EventArgs e)
        {
            if (isEdit)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                isEdit = false;
                Profile_Edit_Button.Text = "Редактировать";
            }
            else
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                isEdit = true;
                Profile_Edit_Button.Text = "Сохранить";
            }
        }
    }
}
