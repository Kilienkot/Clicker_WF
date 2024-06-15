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
        double money = 0,
               koef = 1,
               koef_price = 100,
               interval_price = 300,
               power = 100;


        int interval = 5000;




        public Clicker_game()
        {
            InitializeComponent();
            game.Appearance = TabAppearance.FlatButtons;
            game.ItemSize = new Size(0, 1);
            game.SizeMode = TabSizeMode.Fixed;

            if (MessageBox.Show("Загрузить сохранение?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    StreamReader sl = new StreamReader("savegame.txt");

                   money = Convert.ToDouble(sl.ReadLine());
                   koef = Convert.ToDouble(sl.ReadLine());
                   koef_price = Convert.ToDouble(sl.ReadLine());
                   power = Convert.ToDouble(sl.ReadLine());
                   interval_price = Convert.ToDouble(sl.ReadLine());

                   interval = Convert.ToInt32(sl.ReadLine());

                    money_box.Text = money.ToString();
                    power_box.Text = "Остаток сил: " + power.ToString();

                    sl.Close();
                   MessageBox.Show("Сохранение загружено!\nХороших кликов!", "Сохранение");
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Файл сохранения не найден:(", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void select_shop_Click(object sender, EventArgs e)
        {
            money = Convert.ToDouble(money_box.Text);
            money_box_shop.Text = "Баланс = " + Convert.ToString(money);
            game.SelectedTab = shop;
        }
        private void select_clicker_Click(object sender, EventArgs e)
        {
            money_box.Text = Convert.ToString(money);
            power_box.Text = "Остаток сил: " + Convert.ToString(power);
            game.SelectedTab = clicker;
        }

        private void Click_me_Click(object sender, EventArgs e)
        {
            if (power > 0)
            {
                money += koef;
                money_box.Text = Convert.ToString(money);
                power = power - 1;
                power_box.Text = "Остаток сил: " + Convert.ToString(power);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Clicker_game_FormClosing(object sender, FormClosingEventArgs e)
        {
           //if (e.CloseReason == CloseReason.UserClosing) e.Cancel = true;
           //else
           //{
                StreamWriter save = new StreamWriter("savegame.txt");
                
                save.WriteLine(money);
                save.WriteLine(koef);
                save.WriteLine(koef_price);
                save.WriteLine(power);
                save.WriteLine(interval_price);
                save.WriteLine(interval);
                save.Close();
                MessageBox.Show("Прогресс сохранён!\nДо новых кликов!", "Сохранение");
            //}
        }

        private void shop_item1_Click(object sender, EventArgs e)
        {
            if (money >= koef_price && (MessageBox.Show($"Увеличивает добычу на 1\nХотите купить? Цена: {koef_price}", "Добыча", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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

        private void shop_item2_Click(object sender, EventArgs e)
        {
            if (money >= 50 && power < 900 && (MessageBox.Show("Восполняет 100 энергии (макс: 999)\nХотите купить? Цена: 50", "Энергия", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                power += 100;
                money -= 50;
                money_box_shop.Text = "Баланс = " + Convert.ToString(money);
            }
            else if (money < koef_price)
            {
                MessageBox.Show($"Недостаточно средств\nСтоимость: 50\nНе хватает: {50 - money}", "Недостаточно средств", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void shop_item3_Click(object sender, EventArgs e)
        {
            if (money >= interval_price && autoclick.Enabled == false && (MessageBox.Show($"Включает автокликкер с периодом срабатывания 5с\nХотите купить? Цена: {interval_price}", "Автокликкер", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                autoclick.Interval = interval;
                autoclick.Enabled = true;
                money -= interval_price;
                interval_price += 100;
                money_box_shop.Text = "Баланс = " + Convert.ToString(money);
            }
            else if (money >= interval_price && interval > 500 && (MessageBox.Show($"Уменьшает время работы автокликкера на 0.5с\nХотите купить? Цена: {interval_price}", "Автокликкер", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                interval -= 500;
                autoclick.Interval = interval;
                money -= interval_price;
                interval_price += 100;
                money_box_shop.Text = "Баланс = " + Convert.ToString(money);
            }
            else if (money < interval_price)
            {
                MessageBox.Show($"Недостаточно средств\nСтоимость: {interval_price}\nНе хватает: {interval_price - money}", "Недостаточно средств", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void autockick1(object sender, EventArgs e)
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
