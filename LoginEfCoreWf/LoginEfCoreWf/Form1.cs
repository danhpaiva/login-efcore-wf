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
            //login: danielpaiva
            //senha: amo.corrida

            var login = tb_login.Text.ToString();
            var senha = tb_senha.Text.ToString();

            if (!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(senha))
            {
                using var db = new LoginContext();

                db.Add(new Login { Nome = login, Senha = senha });
                db.SaveChangesAsync();

                MessageBox.Show("Tudo deu certo! Dados cadastrados!\nLogado no Sistema!");
            } else
                MessageBox.Show("Voce precisa preencher os dois campos!");
        }
    }
}
