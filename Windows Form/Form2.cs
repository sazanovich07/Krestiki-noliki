﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windows_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента ProgressBar " + '\r' + '\n' +
            "1. Minimum: минимальное возможное значение" + '\r' + '\n' +
            "2. Maximum: максимальное возможное значение" + '\r' + '\n' +
            "3. Value: текущее значение элемента" + '\r' + '\n' +
            "4. Step: шаг, на который изменится значение Value при вызове метода PerformStep";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента TabControl " + '\r' + '\n' +
            "1. Элемент SplitContainer позволяет создавать две разделенные сплитером панели. Изменяя положение сплитера, можно изменить размеры этих панелей.";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента TextBox " + '\r' + '\n' +
            "1. None: без прокруток(по умолчанию)" + '\r' + '\n' +
            "2. Horizontal: создает горизонтальную прокрутку при длине строки, превышающей ширину текстового поля" + '\r' + '\n' +
            "3. Vertical: создает вертикальную прокрутку, если строки не помещаются в текстовом поле" + '\r' + '\n' +
            "4. Both: создает вертикальную и горизонтальную прокрутку" + '\r' + '\n' +
            " События компонента TextBox " + '\r' + '\n' +
            "1. Событие TextChanged, которое срабатывает при изменении текста в элементе.";
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента MaskedTextBox " + '\r' + '\n' +
            "1. None: без прокруток(по умолчанию)" + '\r' + '\n' +
            "2. Свойство HidePromptOnLeave при установке в true при потери текстовым полем фокуса скрывает, указанные в PromptChar" + '\r' + '\n' +
            "3. Свойство PromptChar указывает на символ, который отображается в поле на месте ввода символов.По умолчанию стоит знак подчеркивания." + '\r' + '\n' +
            "4. Свойство AsciiOnly при значении true позволяет вводить только asci-символы, то есть символы из диапазона A-Z и a-z.";
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента ListBox " + '\r' + '\n' +
            "1. Ключевым свойством этого элемента является свойство Items, которое как раз и хранит набор всех элементов списка." + '\r' + '\n' +
            "2. Для добавления нового элемента в эту коллекцию, а значит и в список, надо использовать метод Add," + '\r' + '\n' +
            "3. Для удаления элемента по его тексту используется метод Remove:" + '\r' + '\n' +
            "4. SelectedIndex: возвращает или устанавливает номер выделенного элемента списка.Если выделенные элементы отсутствуют, тогда свойство имеет значение -1" + '\r' + '\n' +
            "5. SelectedItem: возвращает или устанавливает текст выделенного элемента" + '\r' + '\n' +
            "События компонента ListBox " + '\r' + '\n' +
            "6. Из всех событий элемента ListBox надо отметить в первую очередь событие SelectedIndexChanged, которое возникает при изменении выделенного элемента:";

        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента OpenFileDialog " + '\r' + '\n' +
             "1. DefaultExt: устанавливает расширение файла, которое добавляется по умолчанию, если пользователь ввел имя файла без расширения" + '\r' + '\n' +
             "2. AddExtension: при значении true добавляет к имени файла расширение при его отсуствии.Расширение берется из свойства DefaultExt или Filter" + '\r' + '\n' +
             "3. CheckFileExists: если имеет значение true, то проверяет существование файла с указанным именем" + '\r' + '\n' +
             "4. FileName: возвращает полное имя файла, выбранного в диалоговом окне" + '\r' + '\n' +
             "5. SelectedItem: возвращает или устанавливает текст выделенного элемента" + '\r' + '\n' +
             "События компонента ListBox " + '\r' + '\n' +
             "6. Из всех событий элемента ListBox надо отметить в первую очередь событие SelectedIndexChanged, которое возникает при изменении выделенного элемента:";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента FolderBrowserDialog " + '\r' + '\n' +
             "1. Свойство Description определяет заголовок диалога, в котором будет выбираться папка." + '\r' + '\n' +
             "2. Свойство RootFolder позволяет выбрать стандартную папку, которая будет корневой при открытии стандартного диалогового окна Windows открытия папки." + '\r' + '\n' +
             "3. Метод Execute осуществляет инициализацию стандартного диалогового окна Windows открытия папки." + '\r' + '\n' +
             "4. FileName: возвращает полное имя файла, выбранного в диалоговом окне" + '\r' + '\n' +
             "5. SelectedItem: возвращает или устанавливает текст выделенного элемента" + '\r' + '\n' +
             "События компонента ListBox " + '\r' + '\n' +
             "6. Из всех событий элемента ListBox надо отметить в первую очередь событие SelectedIndexChanged, которое возникает при изменении выделенного элемента:";
        }
        private void label5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Свойства и методы элемента SaveFileDialog " + '\r' + '\n' +
             "1. CreatePrompt: при значении true в случае, если указан не существующий файл, то будет отображаться сообщение о его создании" + '\r' + '\n' +
             "2. OverwritePrompt: при значении true в случае, если указан существующий файл, то будет отображаться сообщение о том, что файл будет перезаписан" + '\r' + '\n' +
             "3. Чтобы отобразить диалоговое окно, надо вызвать метод ShowDialog()." + '\r' + '\n' +
             "Свойства и методы элемента GroupBox " + '\r' + '\n' +
             "1. Свойство Color определяет цвет фона компонента." + '\r' + '\n' +
             "События компонента ListBox " + '\r' + '\n' +
             "1. Свойство Tag не используется компилятором. Пользователь может изменить значение данного свойства и использовать его по своему усмотрению." + '\r' + '\n' +
             "2. Метод DoDragDrop позволяет начать операцию перетаскивания.";
             }
    }
}
