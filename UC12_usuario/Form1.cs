using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC12_usuario
{
    public partial class Form1 : Form
    {
        string permissao;
        public Form1()
        {
            InitializeComponent();
            MySQLConexao.conexao = new MySqlConnection(MySQLConexao.servidor);
            MySQLConexao.comando = MySQLConexao.conexao.CreateCommand();
            
        }

        private void buttonCADASTRO_Click(object sender, EventArgs e)
        {
            if (textBoxNOME.Text != string.Empty)
            {
                if (comboBoxPERMISSAO.Text == "Funcionário")
                {
                    permissao = "Funcionário";
                }

                if (comboBoxPERMISSAO.Text == "Administrador")
                {
                    permissao = "Administrador";
                }
                if (comboBoxPERMISSAO.Text == "Cliente")
                {
                    permissao = "Cliente";
                }
                string data_cadastro = DateTime.Now.ToString("yyyy-MM-dd"); //formata a data para o padrão do banco de dados
                

                if (textBoxNOME.Text == "") //verifica se o campo nome está vazio
                {

                    MessageBox.Show("Campo nome vazio!"); //mensagem de erro
                    textBoxNOME.Focus(); //foca no campo nome
                    return; //retorna para o início do método
                }
                


                if (textBoxEMAIL.Text == "") //verifica se o campo email está vazio
                {
                    MessageBox.Show("Campo email vazio!"); //mensagem de erro
                    textBoxEMAIL.Focus(); //foca no campo email
                    return; //retorna para o início do método
                }

                if (textBoxSENHA.Text.Length >= 8)
                {
                    if (textBoxSENHA.Text != textBoxCONFSENHA.Text) //verifica se as senhas são iguais
                    {

                        MessageBox.Show("As senhas não conferem!"); //mensagem de erro
                        textBoxSENHA.Focus(); //foca no campo senha
                        return; //retorna para o início do método
                    }
                    
                }
                else
                {
                    MessageBox.Show("A senha deve ter no mínimo 8 caracteres!"); //mensagem de erro
                    textBoxSENHA.Focus(); //foca no campo senha
                    return; //retorna para o início do método
                }
                MySQLConexao.conexao.Open();
                MySQLConexao.comando.CommandText = "INSERT INTO tbl_usuario (nome, email, senha,data_cad,permissao) VALUES ('" + textBoxNOME.Text + "','" + textBoxEMAIL.Text + "','" + textBoxSENHA.Text + "','" + data_cadastro + "','" + permissao + "');"; //instrução SQL para inserir os dados no banco de dados

                try  //tentativa
                {
                    MySQLConexao.comando.ExecuteNonQuery(); //executa o comando SQL 
                    MessageBox.Show("Insert realizado com sucesso!"); //mensagem de sucesso


                }
                catch (Exception erroBD)  //tratamento de erro
                {
                    MessageBox.Show("Erro ao inserir os dados: " + erroBD.Message); //mensagem de erro

                }

                finally  // acabou o comando

                {
                    if (MySQLConexao.conexao.State == ConnectionState.Open) //verifica se a conexão está aberta
                    {
                        MySQLConexao.conexao.Close(); //fechando a conexão com o banco de dados
                    }
                }
            }
        }
    }
}
