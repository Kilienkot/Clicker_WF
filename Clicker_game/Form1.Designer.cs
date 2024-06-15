namespace Clicker_game
{
    partial class Clicker_game
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.game = new System.Windows.Forms.TabControl();
            this.autoclick = new System.Windows.Forms.Timer(this.components);
            this.clicker = new System.Windows.Forms.TabPage();
            this.select_shop = new System.Windows.Forms.PictureBox();
            this.Click_me = new System.Windows.Forms.PictureBox();
            this.power_box = new System.Windows.Forms.TextBox();
            this.money_box = new System.Windows.Forms.TextBox();
            this.shop = new System.Windows.Forms.TabPage();
            this.select_clicker = new System.Windows.Forms.PictureBox();
            this.shop_item3 = new System.Windows.Forms.PictureBox();
            this.shop_item2 = new System.Windows.Forms.PictureBox();
            this.shop_item1 = new System.Windows.Forms.PictureBox();
            this.money_box_shop = new System.Windows.Forms.TextBox();
            this.game.SuspendLayout();
            this.clicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_shop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Click_me)).BeginInit();
            this.shop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_clicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_item3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_item1)).BeginInit();
            this.SuspendLayout();
            // 
            // game
            // 
            this.game.Controls.Add(this.clicker);
            this.game.Controls.Add(this.shop);
            this.game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game.Location = new System.Drawing.Point(0, 0);
            this.game.Name = "game";
            this.game.SelectedIndex = 0;
            this.game.Size = new System.Drawing.Size(384, 612);
            this.game.TabIndex = 0;
            // 
            // autoclick
            // 
            this.autoclick.Tick += new System.EventHandler(this.autockick1);
            // 
            // clicker
            // 
            this.clicker.BackColor = System.Drawing.Color.Transparent;
            this.clicker.BackgroundImage = global::Clicker_game.Properties.Resources.background2_0;
            this.clicker.Controls.Add(this.select_shop);
            this.clicker.Controls.Add(this.Click_me);
            this.clicker.Controls.Add(this.power_box);
            this.clicker.Controls.Add(this.money_box);
            this.clicker.Location = new System.Drawing.Point(4, 22);
            this.clicker.Name = "clicker";
            this.clicker.Padding = new System.Windows.Forms.Padding(3);
            this.clicker.Size = new System.Drawing.Size(376, 586);
            this.clicker.TabIndex = 0;
            this.clicker.Text = "clicker";
            // 
            // select_shop
            // 
            this.select_shop.BackColor = System.Drawing.Color.Transparent;
            this.select_shop.BackgroundImage = global::Clicker_game.Properties.Resources.shop2_0;
            this.select_shop.Location = new System.Drawing.Point(63, 504);
            this.select_shop.Name = "select_shop";
            this.select_shop.Size = new System.Drawing.Size(250, 73);
            this.select_shop.TabIndex = 3;
            this.select_shop.TabStop = false;
            this.select_shop.Click += new System.EventHandler(this.select_shop_Click);
            // 
            // Click_me
            // 
            this.Click_me.BackgroundImage = global::Clicker_game.Properties.Resources.coin2_0;
            this.Click_me.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Click_me.Location = new System.Drawing.Point(63, 157);
            this.Click_me.Name = "Click_me";
            this.Click_me.Size = new System.Drawing.Size(250, 250);
            this.Click_me.TabIndex = 2;
            this.Click_me.TabStop = false;
            this.Click_me.Click += new System.EventHandler(this.Click_me_Click);
            // 
            // power_box
            // 
            this.power_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
            this.power_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.power_box.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power_box.ForeColor = System.Drawing.Color.White;
            this.power_box.Location = new System.Drawing.Point(63, 413);
            this.power_box.Name = "power_box";
            this.power_box.ReadOnly = true;
            this.power_box.Size = new System.Drawing.Size(250, 31);
            this.power_box.TabIndex = 1;
            this.power_box.Text = "Остаток сил: 100";
            this.power_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // money_box
            // 
            this.money_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(134)))));
            this.money_box.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_box.Location = new System.Drawing.Point(63, 64);
            this.money_box.Name = "money_box";
            this.money_box.ReadOnly = true;
            this.money_box.Size = new System.Drawing.Size(250, 46);
            this.money_box.TabIndex = 0;
            this.money_box.Text = "0";
            this.money_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shop
            // 
            this.shop.BackColor = System.Drawing.Color.Transparent;
            this.shop.BackgroundImage = global::Clicker_game.Properties.Resources.background2_0;
            this.shop.Controls.Add(this.select_clicker);
            this.shop.Controls.Add(this.shop_item3);
            this.shop.Controls.Add(this.shop_item2);
            this.shop.Controls.Add(this.shop_item1);
            this.shop.Controls.Add(this.money_box_shop);
            this.shop.Location = new System.Drawing.Point(4, 22);
            this.shop.Name = "shop";
            this.shop.Padding = new System.Windows.Forms.Padding(3);
            this.shop.Size = new System.Drawing.Size(376, 586);
            this.shop.TabIndex = 1;
            this.shop.Text = "shop";
            // 
            // select_clicker
            // 
            this.select_clicker.BackColor = System.Drawing.Color.Transparent;
            this.select_clicker.BackgroundImage = global::Clicker_game.Properties.Resources.back2_0;
            this.select_clicker.Location = new System.Drawing.Point(63, 504);
            this.select_clicker.Name = "select_clicker";
            this.select_clicker.Size = new System.Drawing.Size(250, 74);
            this.select_clicker.TabIndex = 7;
            this.select_clicker.TabStop = false;
            this.select_clicker.Click += new System.EventHandler(this.select_clicker_Click);
            // 
            // shop_item3
            // 
            this.shop_item3.BackColor = System.Drawing.Color.Transparent;
            this.shop_item3.BackgroundImage = global::Clicker_game.Properties.Resources.auto2_0;
            this.shop_item3.Location = new System.Drawing.Point(63, 364);
            this.shop_item3.Name = "shop_item3";
            this.shop_item3.Size = new System.Drawing.Size(250, 70);
            this.shop_item3.TabIndex = 6;
            this.shop_item3.TabStop = false;
            this.shop_item3.Click += new System.EventHandler(this.shop_item3_Click);
            // 
            // shop_item2
            // 
            this.shop_item2.BackColor = System.Drawing.Color.Transparent;
            this.shop_item2.BackgroundImage = global::Clicker_game.Properties.Resources.power2_0;
            this.shop_item2.Location = new System.Drawing.Point(63, 279);
            this.shop_item2.Name = "shop_item2";
            this.shop_item2.Size = new System.Drawing.Size(250, 70);
            this.shop_item2.TabIndex = 5;
            this.shop_item2.TabStop = false;
            this.shop_item2.Click += new System.EventHandler(this.shop_item2_Click);
            // 
            // shop_item1
            // 
            this.shop_item1.BackColor = System.Drawing.Color.Transparent;
            this.shop_item1.BackgroundImage = global::Clicker_game.Properties.Resources.mine2_0;
            this.shop_item1.Location = new System.Drawing.Point(63, 189);
            this.shop_item1.Name = "shop_item1";
            this.shop_item1.Size = new System.Drawing.Size(250, 70);
            this.shop_item1.TabIndex = 4;
            this.shop_item1.TabStop = false;
            this.shop_item1.Click += new System.EventHandler(this.shop_item1_Click);
            // 
            // money_box_shop
            // 
            this.money_box_shop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(134)))));
            this.money_box_shop.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_box_shop.Location = new System.Drawing.Point(63, 64);
            this.money_box_shop.Name = "money_box_shop";
            this.money_box_shop.Size = new System.Drawing.Size(250, 46);
            this.money_box_shop.TabIndex = 1;
            this.money_box_shop.Text = "0";
            this.money_box_shop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Clicker_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 612);
            this.Controls.Add(this.game);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 651);
            this.MinimumSize = new System.Drawing.Size(400, 651);
            this.Name = "Clicker_game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clicker_game_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.game.ResumeLayout(false);
            this.clicker.ResumeLayout(false);
            this.clicker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_shop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Click_me)).EndInit();
            this.shop.ResumeLayout(false);
            this.shop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_clicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_item3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_item1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl game;
        private System.Windows.Forms.TabPage clicker;
        private System.Windows.Forms.TextBox money_box;
        private System.Windows.Forms.TabPage shop;
        private System.Windows.Forms.PictureBox select_shop;
        private System.Windows.Forms.PictureBox Click_me;
        private System.Windows.Forms.TextBox power_box;
        private System.Windows.Forms.PictureBox select_clicker;
        private System.Windows.Forms.PictureBox shop_item3;
        private System.Windows.Forms.PictureBox shop_item2;
        private System.Windows.Forms.PictureBox shop_item1;
        private System.Windows.Forms.TextBox money_box_shop;
        private System.Windows.Forms.Timer autoclick;
    }
}

