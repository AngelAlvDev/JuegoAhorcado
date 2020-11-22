using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoAhorcado
{
    public partial class AdminControl : UserControl
    {
        
        private static AdminControl _instance;
        public static AdminControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminControl();
                return _instance;
            }
        }
        private void UpdateDictionary()
        {
            
            
            dictionaryListBox.BeginUpdate();
            dictionaryListBox.Items.Clear();
            foreach (String palabra in dictionary.GetWords())
            {
                dictionaryListBox.Items.Add(palabra);
            }
            dictionaryListBox.EndUpdate();
        }

        static Dictionary dictionary = new Dictionary();
        String dictionaryFile = "..\\..\\Dictionaries\\diccionario.txt";
        
        public AdminControl()
        {
            dictionary.ReadDictionary(dictionaryFile);
            InitializeComponent();
            UpdateDictionary();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if(wordTextBox.Text != "")
            {
                dictionaryListBox.Items.Clear();
                dictionary.AgregateToDictionary(dictionaryFile, wordTextBox.Text);
                UpdateDictionary();
                
            }
        }
    }
}
