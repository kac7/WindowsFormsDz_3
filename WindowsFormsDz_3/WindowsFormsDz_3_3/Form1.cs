using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDz_3_3
{
    //Задание 3
    //Разработайте приложение, которое состоит из двух форм.Первая форма содержит TextBox доступный только для 
    //чтения и две кнопки «загрузить файл» и «редактировать». Кнопка «редактировать» изначально неактивна. 
    //При нажатии на первую кнопку, открывается диалог и пользователю предлагают выбрать текстовый файл.
    //Выбранный файл загружается в TextBox и кнопка «редактировать» становится активной.
    //При нажатии на вторую кнопку открывается вторая форма (не модально), которая содержит TextBox 
    //доступный для редактирования и две кнопки «Сохранить» и «Отменить». При нажатии на первую кнопку 
    //изменения отображаются в TextBox первой формы.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
