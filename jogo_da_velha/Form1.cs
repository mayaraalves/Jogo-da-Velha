using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jogo_da_velha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Njogador1, Njogador2;
        int Pjogador1 =0, Pjogador2 = 0;
        string jogada;
        int cont = 0, empates = 0;

        //BOTÃO PARA INICIAR
        private void button1_Click(object sender, EventArgs e)
        {
            Habilitar_Botões();
            Njogador1 = textBox1.Text;
            textBox1.Visible = false;
            LB_JOGADOR1.Text = Njogador1 + "  -Joga com:  ";

            Njogador2 = textBox2.Text;
            textBox2.Visible = false;
            LB_JOGADOR2.Text = Njogador2 + " -Joga com:  ";

            if (rb_X.Checked)
            {
                LB_JOGADOR1.Text = LB_JOGADOR1.Text + " X ";
                rb_O.Checked =  true;
                
            }
            else if (rb_O.Checked)
            {
                LB_JOGADOR1.Text = LB_JOGADOR1.Text + " O ";
                rb_X.Checked = true;
            }
            if (rb_X.Checked)
            {
                LB_JOGADOR2.Text = LB_JOGADOR2.Text + "X";
                rb_X.Checked = true;
            }
            else if (rb_O.Checked)
            {
                LB_JOGADOR2.Text = LB_JOGADOR2.Text + "O";
                rb_X.Checked = true;
            }

            lb_Pjogador1.Text = " 0  Vitória(s)";
            lb_Pjogador2.Text = " 0  Vitória(s)";

         
        }


        //BOTÃO FECHAR
        private void button11_Click(object sender, EventArgs e)
        {
            Close();

        }

        //MÉTODO LIMPAR
        public void LIMPAR()
        {
            but1.Text = "";
            but2.Text = "";
            but3.Text = "";
            but4.Text = "";
            but5.Text = "";
            but6.Text = "";
            but7.Text = "";
            but8.Text = "";
            but9.Text = "";
            but9.Text = "";
            //panel3.Enabled = true;
            Habilitar_Botões();
            cont = 0;
        }

        public void Habilitar_Botões()
        {
            but1.Enabled = true;
            but2.Enabled = true;
            but3.Enabled = true;
            but4.Enabled = true;
            but5.Enabled = true;
            but6.Enabled = true;
            but7.Enabled = true;
            but8.Enabled = true;
            but9.Enabled = true;
            

        }


        public void vencedor()
        {
            if (
                 (but1.Text == "X") && (but2.Text == "X") && (but3.Text == "X") ||
                  (but4.Text == "X") && (but5.Text == "X") && (but6.Text == "X") ||
                  (but7.Text == "X") && (but8.Text == "X") && (but9.Text == "X") ||
                  (but1.Text == "X") && (but5.Text == "X") && (but9.Text == "X") ||
                  (but3.Text == "X") && (but5.Text == "X") && (but7.Text == "X") ||
                  (but2.Text == "X") && (but5.Text == "X") && (but8.Text == "X") ||
                  (but1.Text == "X") && (but4.Text == "X") && (but7.Text == "X") ||
                  (but3.Text == "X") && (but6.Text == "X") && (but9.Text == "X")
                
                )
            {
                MessageBox.Show(" X  Ganhou!");
                LIMPAR();
                Habilitar_Botões();
                Pjogador1 = Pjogador1 + 1;
                lb_Pjogador1.Text = Pjogador1.ToString() + " -VITÓRIA(S)";
               
            }

            else if ((but1.Text == "O") && (but2.Text == "O") && (but3.Text == "O") ||
                   (but4.Text == "O") && (but5.Text == "O") && (but6.Text == "O") ||
                   (but7.Text == "O") && (but8.Text == "O") && (but9.Text == "O") ||
                   (but1.Text == "O") && (but5.Text == "O") && (but9.Text == "O") ||
                   (but3.Text == "O") && (but5.Text == "O") && (but7.Text == "O") ||
                   (but2.Text == "O") && (but5.Text == "O") && (but8.Text == "O") ||
                   (but1.Text == "O") && (but4.Text == "O") && (but7.Text == "O") ||
                   (but3.Text == "O") && (but6.Text == "O") && (but9.Text == "O"))

                   
               
               
            {
                MessageBox.Show(" O  Ganhou!");
                LIMPAR();
                Habilitar_Botões();
                Pjogador2 = Pjogador2 + 1;
                lb_Pjogador2.Text = Pjogador2.ToString() + " -VITÓRIA(S)";
            }

                if (cont >= 9) 
                {
                    empates = empates + 1;
                    lb_empate.Text = empates.ToString() + "  Empate(s)";
                     MessageBox.Show("  Empatou!");
                    cont = 0;
                    LIMPAR();
                    Habilitar_Botões();
                }
        }


        
           
      

        private void but1_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                but1.Text = jogada;
                but1.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                but1.Text = jogada;
                but1.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                but2.Text = jogada;
                but2.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                but2.Text = jogada;
                but2.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                but3.Text = jogada;
                but3.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                but3.Text = jogada;
                but3.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                but4.Text = jogada;
                but4.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                but4.Text = jogada;
                but4.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                but5.Text = jogada;
                but5.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                but5.Text = jogada;
                but5.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                but6.Text = jogada;
                but6.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                but6.Text = jogada;
                but6.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                but7.Text = jogada;
                but7.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                but7.Text = jogada;
                but7.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                but8.Text = jogada;
                but8.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                but8.Text = jogada;
                but8.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                but9.Text = jogada;
                but9.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                but9.Text = jogada;
                but9.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LIMPAR();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            but1.Enabled = false;
            but2.Enabled = false;
            but3.Enabled = false;
            but4.Enabled = false;
            but5.Enabled = false;
            but6.Enabled = false;
            but7.Enabled = false;
            but8.Enabled = false;
            but9.Enabled = false;
            


        }

       
        

     

       
      
      

       

      


      
       

        
       
      
    }
}
