using LoginEfCoreWf.Context;
using LoginEfCoreWf.Models;

namespace LoginEfCoreWf
{
    public partial class f_login : Form
    {
        public f_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var login = tb_login.Text.ToString();
            var senha = tb_senha.Text.ToString();

            if (!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(senha))
            {
                using var db = new LoginContext();

                try
                {
                    db.Add(new Login { Nome = login, Senha = senha });
                    db.SaveChangesAsync();
                }
                catch (Exception erro)
                {
                    MessageBox.Show($"Aconteceu um erro ao tentar cadastrar a senha e logar:\n{erro.Message}");
                }

                MessageBox.Show("Tudo deu certo! Dados cadastrados!\nLogado no Sistema!");
            } else
                MessageBox.Show("Voce precisa preencher os dois campos!");
        }
    }
}
