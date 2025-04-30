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
        string idalterar;
        string permissao;
        public Form1()
        {
            InitializeComponent();
            MySQLConexao.conexao = new MySqlConnection(MySQLConexao.servidor);
            MySQLConexao.comando = MySQLConexao.conexao.CreateCommand();
            preecheDataGridUSUARIOS(); //chama o método para preencher o DataGridView com os dados do banco de dados
            



        }

        private void preecheDataGridUSUARIOS() //preenche o DataGridView com os dados do banco de dados PROCEDIMENTO
        {
            MySQLConexao.conexao.Open(); //abrindo a conexão com o banco de dados
            MySQLConexao.comando.CommandText = "SELECT * FROM tbl_usuario"; //instrução SQL para selecionar todos os dados da tabela tbl_usuario


            MySqlDataAdapter adaptador = new MySqlDataAdapter(MySQLConexao.comando); //cria um adaptador para preencher o DataGridView
            DataTable TabelaUSUARIOS = new DataTable(); //cria uma tabela para armazenar os dados
            adaptador.Fill(TabelaUSUARIOS); //preenche a tabela com os dados do banco de dados



            try
            {
                MySQLConexao.comando.ExecuteNonQuery(); //executa o comando SQL
                dataGridUSUARIOS.DataSource = TabelaUSUARIOS; //preenche o DataGridView com os dados da tabela


            }

            catch (Exception erroBD) //tratamento de erro
            {
                MessageBox.Show("Erro ao selecionar os dados: " + erroBD.Message); //mensagem de erro
            }
            finally // acabou o comando
            {
                if (MySQLConexao.conexao.State == ConnectionState.Open) //verifica se a conexão está aberta
                {
                    MySQLConexao.conexao.Close(); //fechando a conexão com o banco de dados
                }

            }

        }


        private void buttonCADASTRO_Click(object sender, EventArgs e)
        {
            buttonCADASTRO.Text = "Cadastrar"; //altera o texto do botão para Cadastrar
            if (idalterar == null)
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
                            labelCONF.Image = Properties.Resources.x; 
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
            else
            {
                
                if (textBoxNOME.Text != string.Empty && textBoxEMAIL.Text != string.Empty && textBoxSENHA.Text != string.Empty && comboBoxPERMISSAO.Text != string.Empty && textBoxSENHA.Text.Length >= 8 && textBoxSENHA.Text == textBoxCONFSENHA.Text)
                {

                    //UPDATE

                    MySQLConexao.conexao.Open();
                    MySQLConexao.comando.CommandText = "UPDATE tbl_usuario SET nome = '" + textBoxNOME.Text + "', email = '" + textBoxEMAIL.Text + "' , permissao = '" + comboBoxPERMISSAO+"'WHERE id = '" + idalterar + "';";
                    try
                    {
                        MySQLConexao.comando.ExecuteNonQuery();
                        MessageBox.Show("Atualização realizada com sucesso!");
                    }
                    catch (MySqlException erroBD)
                    {
                        MessageBox.Show("ERRO ao atualizar!" +erroBD.Message);
                        //MessageBox.Show(erroBD.Message);

                    }
                    finally
                    {
                        if (MySQLConexao.conexao.State == ConnectionState.Open)
                        {
                            MySQLConexao.conexao.Close();
                        }
                    }
                    idalterar = null;
                }
                else
                {
                    MessageBox.Show("Observe: Campos preenchidos, Senhas com 8 caracteres ou mais e Confirmação de Senha!");
                }
            }
            

            preecheDataGridUSUARIOS(); //chama o método para preencher o DataGridView com os dados do banco de dados
            textBoxNOME.Clear(); //limpa o campo nome
            textBoxEMAIL.Clear(); //limpa o campo email
            textBoxSENHA.Clear(); //limpa o campo senha
            textBoxCONFSENHA.Clear(); //limpa o campo confirmar senha               
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Você tem certeza que deseja excluir? " + dataGridUSUARIOS.CurrentRow.Cells[1].Value.ToString() + " de e-mail " + dataGridUSUARIOS.CurrentRow.Cells[2].Value.ToString()); //pega o valor da célula 0 da linha atual do DataGridView

            //MessageBox.Show("Você tem certeza que deseja excluir o usuário?"); //mensagem de confirmação

            if (MessageBox.Show("Você tem certeza que deseja excluir o usuário " + dataGridUSUARIOS.CurrentRow.Cells[1].Value.ToString() + " de e-mail " + dataGridUSUARIOS.CurrentRow.Cells[2].Value.ToString() + " ?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes) //verifica se o usuário clicou em sim
            {
                MySQLConexao.conexao.Open(); //abrindo a conexão com o banco de dados
                MySQLConexao.comando.CommandText = "DELETE FROM tbl_usuario WHERE id = " + dataGridUSUARIOS.CurrentRow.Cells[0].Value.ToString() + ";"; //instrução SQL para deletar os dados do banco de dados
                try  //tentativa
                {
                    MySQLConexao.comando.ExecuteNonQuery(); //executa o comando SQL 
                    MessageBox.Show("Delete realizado com sucesso!"); //mensagem de sucesso 
                }
                catch (Exception erroBD)  //tratamento de erro
                {
                    MessageBox.Show("Erro ao deletar os dados: " + erroBD.Message); //mensagem de erro
                }
                finally  // acabou o comando
                {
                    if (MySQLConexao.conexao.State == ConnectionState.Open) //verifica se a conexão está aberta
                    {
                        MySQLConexao.conexao.Close(); //fechando a conexão com o banco de dados
                    }
                }
            }
            preecheDataGridUSUARIOS(); //chama o método para preencher o DataGridView com os dados do banco de dados
        }

        private void buttonALTERAR_Click(object sender, EventArgs e)
        {
            textBoxNOME.Text = dataGridUSUARIOS.CurrentRow.Cells[1].Value.ToString();
            textBoxEMAIL.Text = dataGridUSUARIOS.CurrentRow.Cells[2].Value.ToString();
            textBoxSENHA.Text = string.Empty;
            textBoxCONFSENHA.Text = string.Empty;
            comboBoxPERMISSAO.Text = dataGridUSUARIOS.CurrentRow.Cells[5].Value.ToString();

            idalterar = dataGridUSUARIOS.CurrentRow.Cells[0].Value.ToString();
            buttonCADASTRO.Text = "Salvar"; //altera o texto do botão para Cadastrar

        }
    }
}



