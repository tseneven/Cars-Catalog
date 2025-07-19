using Classes;
using WindowsForms.Repositorys.Auth;

namespace WindowsForms
{
    public partial class Auth_Register : Form
    {
        private readonly IAuth_Repository _auth_Repository;
        private readonly Auth_Model _auth_Model;

        public Auth_Register()
        {
            InitializeComponent();
            _auth_Repository = new Auth_Reposirtory();
            _auth_Model = new Auth_Model();
        }

        private async void Auth_button_Click(object sender, EventArgs e)
        {
            _auth_Model.Login = LogLog_textBox.Text;
            _auth_Model.Password = LogPas_textBox.Text;

            string result = await _auth_Repository.Authorization(_auth_Model);

            if (result == "Unauthorized")
            {
                MessageBox.Show("������ ��������");
            }
            else if (result == "NotFound")
            {
                MessageBox.Show("������� �� ������");
            }
            else
            {
                MessageBox.Show("�������� �����������");
                Catalog catalog = new Catalog(int.Parse(result));
                catalog.Show();
                this.Hide();
            }
        }

        private async void Reg_button_Click(object sender, EventArgs e)
        {
            _auth_Model.Login = Log_textBox.Text;
            _auth_Model.Password = Pas_textBox.Text;


            if (Pas_textBox.Text == PovPas_textBox.Text)
            {
                string result = await _auth_Repository.Registration(_auth_Model);

                if (result == "200")
                {
                    MessageBox.Show("�������� �����������");
                }
                else if (result == "409")
                {
                    MessageBox.Show("����� ����� ��� ����������");
                }
                else
                {
                    MessageBox.Show("������ �����������. ���: " + result);
                }
            }
            else
            {
                MessageBox.Show("������ �� ���������");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
