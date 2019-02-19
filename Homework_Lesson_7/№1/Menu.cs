using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Кудинов Даниил
/// 
/// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
/// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок
/// Игрок должен получить это число за минимальное количество ходов.
/// </summary>
namespace _1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
