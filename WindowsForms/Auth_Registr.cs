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
using WindowsForms.Repositorys;

namespace WindowsForms
{
    public partial class Auth_Registr : Form
    {
        private readonly IAuth_Repository _auth_Repository;
        private readonly Auth_Model _auth_Model;
        public Auth_Registr()
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

            if (result == "200")
            {
                MessageBox.Show("Успешная регистрация");
            }
            else if (result == "401")
            {
                MessageBox.Show("Пароль неверный");
            }
            else
            {
                MessageBox.Show("Ошибка регистрации. Код: " + result);
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
                    MessageBox.Show("Успешная регистрация");
                }
                else if (result == "400")
                {
                    MessageBox.Show("Такой логин уже существует");
                }
                else
                {
                    MessageBox.Show("Ошибка регистрации. Код: " + result);
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
    }
}
