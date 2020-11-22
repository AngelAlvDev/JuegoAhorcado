using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace JuegoAhorcado
{
    public partial class GameControl : UserControl
    {
        private string word;
        private string hidingWord;
        private int attempt;
        private bool win = false;
        public int difficult;
        
        private String Missingword()
        {
            Dictionary dictionay = new Dictionary();
            Random rnd = new Random();
            dictionay.ReadDictionary("..\\..\\Dictionaries\\diccionario.txt");
            List<String> lista = dictionay.GetWords();
            int position = rnd.Next(lista.Count);
            try
            {
                return lista[position].ToUpper();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return "";
            }

        }
        private void DrawWord()
        {
            int position = 0;
            missingWordPanel.Controls.Clear();
            foreach(char missingLetter in hidingWord)
            {
                Label charLabel = new Label();
                charLabel.Tag = "";
                if(missingLetter.Equals(' '))
                {
                    charLabel.Text = " ";
                }
                else
                    charLabel.Text = missingLetter.ToString();
                charLabel.Width = 40;
                charLabel.Height = 60;
                charLabel.ForeColor = Color.Black;
                charLabel.Font = new Font(charLabel.Font.Name, 15, FontStyle.Bold);
                charLabel.BackColor = Color.Transparent;
                charLabel.Name = "missingWordLetter" + position.ToString();
                missingWordPanel.Controls.Add(charLabel);
                position++;
            }
        }
        private bool checkCharacter(char character, string word)
        {
            bool character_in_word = false;
            for (int i = 0; i < word.Length && !character_in_word; i++)
                if (word[i].Equals(character))
                    character_in_word = true;
            if (!character_in_word)
            {
                attempt--;
                drawImage(attempt);

            }
            if(attempt == 0)
            {
                MessageBox.Show("Juego finalizado:\nLa palabra buscada era: " + word);
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
            
            return character_in_word;
        }
        private bool Win()
        {
            win = true;
            foreach(char c in hidingWord)  
            {
                if (c.Equals('_'))
                {
                    win = false;
                    break;
                }

            }
            return win;
        }


        private string hideWord()
        {
            char[] hidingWordchars = word.ToCharArray();
            int i = 0;
            foreach(char character in word)
            {
                if(character.Equals(' '))
                    hidingWordchars[i] = ' ';
                else
                    hidingWordchars[i] = '_';
                i++;
            }
            hidingWord = new string(hidingWordchars);
            return hidingWord;
        }

        private string showChar(char character)
        {
            char[] newMissingWord = hidingWord.ToCharArray();
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i].Equals(character))
                    newMissingWord[i] = character;
            }
            return new string(newMissingWord);
        }
        private void drawImage(int intentos)
        {
            if(intentos == 6)
            {
                ahorcadoPictureBox.Image = JuegoAhorcado.Properties.Resources.ahorcado_6;
            }
            else if(intentos == 5)
            {
                ahorcadoPictureBox.Image = JuegoAhorcado.Properties.Resources.ahorcado_5;
            }
            else if(intentos == 4)
            {
                ahorcadoPictureBox.Image = JuegoAhorcado.Properties.Resources.ahorcado_4;
            }
            else if(intentos == 3)
            {
                ahorcadoPictureBox.Image = JuegoAhorcado.Properties.Resources.ahorcado_3;
            }
            else if(intentos == 2)
            {
                ahorcadoPictureBox.Image = JuegoAhorcado.Properties.Resources.ahorcado_2;
            }
            else if(intentos == 1)
            {
                ahorcadoPictureBox.Image = JuegoAhorcado.Properties.Resources.ahorcado_1;
            }
            else if(intentos == 0)
            {
                ahorcadoPictureBox.Image = JuegoAhorcado.Properties.Resources.ahorcado_0;
            }

        }
        private void GameDifficult()
        {
            int i = 0;
            char[] letra = { '-', '-' };
            
            if(difficult == 0)
            {
                do
                {
                    bool valid = true;
                    Random rnd = new Random();
                    do
                    {
                        valid = true;
                        int position = rnd.Next(word.Length);
                        char c = word[position];
                        for(int j=0; j < 2 && valid; j++)
                        {
                            if (c.Equals(letra[j]))
                            {
                                valid = false;
                            }
                        }
                        if(valid)
                            letra[i] = c;
                    } while (!valid);

                    hidingWord = showChar(letra[i]);
                    i++;
                } while (i < 2);
            }
            else if(difficult == 1)
            {
                do
                {
                    bool valid = true;
                    Random rnd = new Random();
                    do
                    {
                        valid = true;
                        int position = rnd.Next(word.Length);
                        char c = word[position];
                        for (int j = 0; j < 2 && valid; j++)
                        {
                            if (c.Equals(letra[j]))
                            {
                                valid = false;
                            }
                        }
                        if (valid)
                            letra[i] = c;
                    } while (!valid);

                    hidingWord = showChar(letra[i]);
                    i++;
                } while (i < 1);
            }
        }
        public GameControl(int dificultad)
        {
            
            difficult = dificultad;
            InitializeComponent();
            attempt = 6;
            win = false;
            
            word = Missingword();
            hidingWord = hideWord();
            GameDifficult();
            DrawWord();
            drawImage(attempt);
            
        }

        private void qButton_Click(object sender, EventArgs e)
        {
            qButton.Enabled = false;
            if(checkCharacter('Q', word))
            {
                hidingWord = showChar('Q');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('Q');
                 
            }
        }

        private void wButton_Click(object sender, EventArgs e)
        {
            wButton.Enabled = false;
            if (checkCharacter('W', word))
            {
                hidingWord = showChar('W');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('W');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            eButton.Enabled = false;
            if (checkCharacter('E', word))
            {
                hidingWord = showChar('E');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('E');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void rButton_Click(object sender, EventArgs e)
        {
            rButton.Enabled = false;
            if (checkCharacter('R', word))
            {
                hidingWord = showChar('R');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('R');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void tbutton_Click(object sender, EventArgs e)
        {
            tButton.Enabled = false;
            if (checkCharacter('T', word))
            {
                hidingWord = showChar('T');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('T');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void yButton_Click(object sender, EventArgs e)
        {
            yButton.Enabled = false;
            if (checkCharacter('Y', word))
            {
                hidingWord = showChar('Y');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('Y');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void uButton_Click(object sender, EventArgs e)
        {
            uButton.Enabled = false;
            if (checkCharacter('U', word))
            {
                hidingWord = showChar('U');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('U');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void iButoon_Click(object sender, EventArgs e)
        {
            iButton.Enabled = false;
            if (checkCharacter('I', word))
            {
                hidingWord = showChar('I');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('I');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void oButton_Click(object sender, EventArgs e)
        {
            oButton.Enabled = false;
            if (checkCharacter('O', word))
            {
                hidingWord = showChar('O');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('O');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void pButton_Click(object sender, EventArgs e)
        {
            pButton.Enabled = false;
            if (checkCharacter('P', word))
            {
                hidingWord = showChar('P');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('P');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            aButton.Enabled = false;
            if (checkCharacter('A', word))
            {
                hidingWord = showChar('A');
                DrawWord();
            }
            else
            {
             
                utilizadasListBox.Items.Add('A');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            sButton.Enabled = false;
            if (checkCharacter('S', word))
            {
                hidingWord = showChar('S');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('S');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            dButton.Enabled = false;
            if (checkCharacter('D', word))
            {
                hidingWord = showChar('D');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('D');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void fButton_Click(object sender, EventArgs e)
        {
            fButton.Enabled = false;
            if (checkCharacter('F', word))
            {
                hidingWord = showChar('F');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('F');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void gButton_Click(object sender, EventArgs e)
        {
            gButton.Enabled = false;
            if (checkCharacter('G', word))
            {
                hidingWord = showChar('G');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('G');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void hButton_Click(object sender, EventArgs e)
        {
            hButton.Enabled = false;
            if (checkCharacter('H', word))
            {
                hidingWord = showChar('H');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('H');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void jButton_Click(object sender, EventArgs e)
        {
            jButton.Enabled = false;
            if (checkCharacter('J', word))
            {
                hidingWord = showChar('J');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('J');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void kButton_Click(object sender, EventArgs e)
        {
            kButton.Enabled = false;
            if (checkCharacter('K', word))
            {
                hidingWord = showChar('K');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('K');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void lButton_Click(object sender, EventArgs e)
        {
            lButton.Enabled = false;
            if (checkCharacter('L', word))
            {
                hidingWord = showChar('L');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('L');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void zButton_Click(object sender, EventArgs e)
        {
            zButton.Enabled = false;
            if (checkCharacter('Z', word))
            {
                hidingWord = showChar('Z');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('Z');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            xButton.Enabled = false;
            if (checkCharacter('X', word))
            {
                hidingWord = showChar('X');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('X');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            cButton.Enabled = false;
            if (checkCharacter('C', word))
            {
                hidingWord = showChar('C');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('C');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void vButton_Click(object sender, EventArgs e)
        {
            vButton.Enabled = false;
            if (checkCharacter('V', word))
            {
                hidingWord = showChar('V');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('V');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            bButton.Enabled = false;
            if (checkCharacter('B', word))
            {
                hidingWord = showChar('B');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('B');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void nButton_Click(object sender, EventArgs e)
        {
            nButton.Enabled = false;
            if (checkCharacter('N', word))
            {
                hidingWord = showChar('N');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('N');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void mButton_Click(object sender, EventArgs e)
        {
            mButton.Enabled = false;
            if (checkCharacter('M', word))
            {
                hidingWord = showChar('M');
                DrawWord();
            }
            else
            {
                utilizadasListBox.Items.Add('M');
                 
            }
            if (Win())
            {
                MessageBox.Show("Enhorabuena, has acertado la palabra");
                this.Controls.Clear();
                this.Controls.Add(new MainControl());

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GameControl gameControl = new GameControl(difficult);

            gameControl.Dock = DockStyle.Fill;
            gameControl.BringToFront();
            gameControl.Focus();


            this.Controls.Clear();
            this.Controls.Add(gameControl);
        }
    }
}
