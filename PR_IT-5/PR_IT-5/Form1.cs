using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_IT_5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      // Получаем номер выделенной строки
      int index = listBox1.SelectedIndex;
      // Считываем строку в перменную str
      string str = (string)listBox1.Items[index];
      // Узнаем количество символов в строке
      int len = str.Length;
      string newStr = "";
      string newStr2 = "";
      // Считаем, что количество пробелов равно 0
      int count = 0;
      // Устанавливаем счетчик символов в 0
      int i = 0, n = 0;
      //Организуем цикл перебора всех символов в строке

      if (radioButton2.Checked) n = 2;
      if (radioButton3.Checked) n = 3;
      if (radioButton4.Checked) n = 4;
      if (radioButton5.Checked) n = 5;
      if (radioButton6.Checked) n = 6;

      switch (n)
      {
        case 2:
          while (i < len - 1)
          {
            // Если нашли пробел, то увеличиваем
            // счетчик пробелов на 1
            if (str[i] == ' ')
              count++;
            i++;
          }
          label1.Text = "Количество пробелов = " +
          count.ToString();
          break;
        case 3:
          while (i < len - 1)
          { 
            if (str[i] == 'а') str = str.Replace('а', 'б');          
            i++;
            label1.Text = "Новая строка - " + str;
          }
            break;
        case 4:
          while (i <= len - 1)
          {

            char ch = str[i];
            newStr += ch;
            newStr += ch;
            i++;
          }
          label1.Text = "Новая строка - " + newStr;
          break;
        case 5:
          i = str.Length - 1;
          while (i >= 0)
          {
            char ch = str[i];
            newStr += ch;
            i--;
          }
          label1.Text = "Новая строка - " + newStr;
          break;
        case 6:
          int g = str.Length - 1;
          i = 0;

          while (g >= 0)
          {
            char ch = str[g];
            newStr += ch;
            g--;
          }
          if (newStr == str)
          {
            label1.Text = "Слово полиндром";
          }
          else
          {
            label1.Text = "Слово не полиндром";
          }
          break;
      }
    }
  }
}
