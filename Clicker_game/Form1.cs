using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_game
{
    public partial class Clicker_game : Form
    {
        double money = 0, //Переменная для сохранения денег
               koef = 1, //Переменная для сохранения коэффициента на который увеличивается сумма при тапе
               koef_price = 100, //Цена увеличения предыдущей переменной
               interval_price = 300, //Цена для покупки автокликкера
               power = 100; //Доступная энергия

        bool en_click = false; //Определение активности автокликкера

        int interval = 5000; //Интервал между тапами автокликкера




        public Clicker_game()
        {
            InitializeComponent();
            game.Appearance = TabAppearance.FlatButtons; //Скрытие TabControl
            game.ItemSize = new Size(0, 1);
            game.SizeMode = TabSizeMode.Fixed;

            if (MessageBox.Show("Загрузить сохранение?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //Вопрос нужно ли загрузить сохранение
            {
                try //Загрузка сохранения
                {

                    StreamReader sl = new StreamReader("savegame.txt"); 

                    money = Convert.ToDouble(sl.ReadLine());
                    koef = Convert.ToDouble(sl.ReadLine());
                    koef_price = Convert.ToDouble(sl.ReadLine());
                    power = Convert.ToDouble(sl.ReadLine());
                    interval_price = Convert.ToDouble(sl.ReadLine());

                    interval = Convert.ToInt32(sl.ReadLine());

                    en_click = Convert.ToBoolean(sl.ReadLine());
                    autoclick.Enabled = en_click;

                    money_box.Text = money.ToString();
                    power_box.Text = "Остаток сил: " + power.ToString();

                    sl.Close();
                    MessageBox.Show("Сохранение загружено!\nХороших кликов!", "Сохранение");
                }
                catch (FileNotFoundException) //Неудача загрузки
                {
                    MessageBox.Show("Файл сохранения не найден:(", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void select_shop_Click(object sender, EventArgs e) //Переход к магазину
        {
            money = Convert.ToDouble(money_box.Text);
            money_box_shop.Text = "Баланс = " + Convert.ToString(money);
            game.SelectedTab = shop;
        }
        private void select_clicker_Click(object sender, EventArgs e) //Переход к кликкеру
        {
            money_box.Text = Convert.ToString(money);
            power_box.Text = "Остаток сил: " + Convert.ToString(power);
            game.SelectedTab = clicker;
        }

        private void Click_me_Click(object sender, EventArgs e) //Обработчик кликов на монету
        {
            if (power > 0)
            {
                money += koef;
                money_box.Text = Convert.ToString(money);
                power = power - 1;
                power_box.Text = "Остаток сил: " + Convert.ToString(power);
            }

        }

        private void Clicker_game_FormClosing(object sender, FormClosingEventArgs e) //Сохранение прогресса
        {
           //if (e.CloseReason == CloseReason.UserClosing) e.Cancel = true; //Я не понял для чего это, но это ломает программу и не даёт закрыть её
           //else
           //{
                StreamWriter save = new StreamWriter("savegame.txt");
                
                save.WriteLine(money);
                save.WriteLine(koef);
                save.WriteLine(koef_price);
                save.WriteLine(power);
                save.WriteLine(interval_price);
                save.WriteLine(interval);
                save.WriteLine(en_click);
    
                save.Close();
                MessageBox.Show("Прогресс сохранён!\nДо новых кликов!", "Сохранение");
            //}
        }

        private void shop_item1_Click(object sender, EventArgs e) //Увеличение добываемых ресурсов за один клик
        {
            if (money >= koef_price && (MessageBox.Show($"Увеличивает добычу на 1\nСейчас добыча с каждого тапа состовляет: {koef}\nХотите увеличить всего за {koef_price}?", "Добыча", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                koef += 1;
                money -= koef_price;
                koef_price += 100;
                money_box_shop.Text = "Баланс = " + Convert.ToString(money);
            }
            else if (money < koef_price)
            {
                MessageBox.Show($"Недостаточно средств\nСтоимость: {koef_price}\nНе хватает: {koef_price - money}", "Недостаточно средств", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void shop_item2_Click(object sender, EventArgs e) //Восполнение энергии затрачевоемой на добычу
        {
            if (money >= 50 && power < 900 && (MessageBox.Show("Восполняет 100 энергии (макс: 999)\nХотите восполнить за 50?", "Энергия", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                power += 100;
                money -= 50;
                money_box_shop.Text = "Баланс = " + Convert.ToString(money);
            }
            else if (money < koef_price)
            {
                MessageBox.Show($"Недостаточно средств\nСтоимость: 50\nНе хватает: {50 - money}", "Недостаточно средств", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (power > 900)
            {
                MessageBox.Show("Максимальный уровень энергии", "Автокликкер", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void shop_item3_Click(object sender, EventArgs e) //Автокликкер
        {
            if (money >= interval_price && en_click == false && (MessageBox.Show($"Включает автокликкер с периодом срабатывания 5с\nТратит в два раза больше энергии\nХотите подключить за скромные {interval_price}?", "Автокликкер", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) //подключение автокликкера
            {
                en_click = true;
                autoclick.Interval = interval;
                autoclick.Enabled = en_click;
                money -= interval_price;
                interval_price += 100;
                money_box_shop.Text = "Баланс = " + Convert.ToString(money);
            }
            else if (money >= interval_price && interval > 500 && (MessageBox.Show($"Уменьшает время работы автокликкера на 0.25с\nХотите улучшить за какие то {interval_price}?", "Автокликкер", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) //Уменьшение времени между тапами у автокликкера
            {
                interval -= 250;
                autoclick.Interval = interval;
                money -= interval_price;
                interval_price += 50;
                money_box_shop.Text = "Баланс = " + Convert.ToString(money);
            }
            else if (money < interval_price)
            {
                MessageBox.Show($"Недостаточно средств\nСтоимость: {interval_price}\nНе хватает: {interval_price - money}", "Недостаточно средств", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (interval == 500)
            {
                MessageBox.Show("Максимальный уровень прокачки", "Автокликкер", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void autockick1(object sender, EventArgs e) //Таймер автокликкера 
        {
            if (power > 0)
            {
                money += koef;
                money_box.Text = Convert.ToString(Convert.ToDouble(money_box.Text) + koef);
                power -= 2;
                power_box.Text = "Остаток сил: " + Convert.ToString(power);
            }
        }
    }
}
