using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeFrota
{
    public partial class ControleDeFrota : Form
    {
        public ControleDeFrota()
        {
            InitializeComponent();
        }

        public class Veiculo // classe veiculo
        {
            private string modelo, placa, Km; // atributos veiculo

            // metodos atribuidores de valores do objeto
            /*public void gravaModelo(string modelo)
            {
                this.modelo = modelo; //adicionando o valor ao atributo
            }

            public void gravaPlaca(string placa)
            {
                this.placa = placa;
            }
            
            public void gravaKm(string Km)
            {
                this.Km = Km;
            }
            
            public string mostraModelo()
            {
                return modelo;
            }

            public string mostraPlaca()
            {
                return placa;
            }
            
            public string mostraKm()
            {
                return Km;
            } */

            public string propriedadesModelo
            {
                set { modelo = value; }
                get { return modelo; }
            }
            public string propriedadePlaca
            {
                set { placa = value; }
                get { return placa; }
            }

            public string propriedadeKm
            {
                set { Km = value; }
                get { return Km; }
            }

        }

        public class Caminhao : Veiculo 
            {
             public string propriedadesEixos { get; set; }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e) //evento click do botao btnsalvar
        {
            if(txtEixos.Visible == false)
            { 
            Veiculo novoCarro = new Veiculo();
            

                /* novoCarro.gravaModelo(txtModelo.Text);
                novoCarro.gravaPlaca(txtPlaca.Text);
                novoCarro.gravaKm(txtKm.Text);

                txtCarros.Text += novoCarro.mostraModelo() + "\t";
                txtCarros.Text += novoCarro.mostraPlaca() + "\t";
                txtCarros.Text += novoCarro.mostraKm() + "\r\n"; */

                novoCarro.propriedadesModelo = txtModelo.Text;
                novoCarro.propriedadePlaca = txtPlaca.Text;
                novoCarro.propriedadeKm = txtKm.Text;

                txtCarros.AppendText(novoCarro.propriedadesModelo + "\t");
                txtCarros.AppendText(novoCarro.propriedadePlaca + "\t");
                txtCarros.AppendText(novoCarro.propriedadeKm + "\r\n");

            }

            else
            {
                Caminhao novoCaminhao = new Caminhao(); // instanciando um objeto do tipo caminhao

                novoCaminhao.propriedadesModelo = txtModelo.Text; //gravar o texto que escreveu dentro do txtModelo
                novoCaminhao.propriedadePlaca = txtPlaca.Text;
                novoCaminhao.propriedadeKm = txtKm.Text;
                novoCaminhao.propriedadesEixos = txtEixos.Text;

                txtCaminhao.AppendText(novoCaminhao.propriedadesModelo + "\t");
                txtCaminhao.AppendText(novoCaminhao.propriedadePlaca + "\t");
                txtCaminhao.AppendText(novoCaminhao.propriedadeKm + "\t");
                txtCaminhao.AppendText(novoCaminhao.propriedadesEixos + "\r\n");

            }

            Limpar();

        }

        private void txtKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCaminhoes_Click(object sender, EventArgs e)
        {
            lblEixos.Visible = true; // transforma em visivel o componente  lblEixos
            txtEixos.Visible = true;
        }

        private void txtCarros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEixos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            lblEixos.Visible = false; //  transforma em invisivel o  componente lblEixos
            txtEixos.Visible = false; // transforma em invisivel o  componente txtEitos
        }

        private void Limpar()
        {
            txtModelo.Clear();
            txtPlaca.Clear();
            txtKm.Clear();
            txtEixos.Clear();

        }
    }
    
        
}
