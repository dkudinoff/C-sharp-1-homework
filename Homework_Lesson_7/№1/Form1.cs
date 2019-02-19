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
/// в) *Добавить кнопку «Отменить», которая отменяет последние ходы.
/// Используйте  библиотечный обобщенный класс System.Collections.Generic.Stack
/// </summary>
namespace _1
{
    public partial class Form1 : Form
    {
        Stack<string> col = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
            BtnCommand1.Text = "+1";
            BtnCommand2.Text = "x2";
            btnBack.Text = "Отмена";
            BtnReset.Text = "Сброс";
            LblNumber.Text = "0";
            lblTry.Text = "Попытки:";
            lblTryNum.Text = "0";
            this.Text = "Удвоитель";
            Random rand = new Random();
            int i = rand.Next(100);
            MessageBox.Show("Вы должны получить число " + i, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTarget.Text = i.ToString();
        }

        private void BtnCommand1_Click(object sender, EventArgs e)
        {
            col.Push(LblNumber.Text);
            LblNumber.Text = (int.Parse(LblNumber.Text) + 1).ToString();
            lblTryNum.Text = (int.Parse(lblTryNum.Text) + 1).ToString();
            
        }
        private void BtnCommand2_Click(object sender, EventArgs e)
        {
            col.Push(LblNumber.Text);
            lblTryNum.Text = (int.Parse(lblTryNum.Text) + 1).ToString();
            LblNumber.Text = (int.Parse(LblNumber.Text) * 2).ToString();
            
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            LblNumber.Text = "0";
            lblTryNum.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (col.Count != 0)
            {
                LblNumber.Text = col.Pop();
                lblTryNum.Text = (int.Parse(lblTryNum.Text) - 1).ToString();
            }
        }
    }
}
