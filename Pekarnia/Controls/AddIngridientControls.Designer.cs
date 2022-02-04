namespace Pekarnia.Controls
{
	partial class AddIngridientControls
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

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.valit = new System.Windows.Forms.ComboBox();
			this.price = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.izmen = new System.Windows.Forms.ComboBox();
			this.kol = new System.Windows.Forms.NumericUpDown();
			this.nazad = new System.Windows.Forms.Button();
			this.add_provider = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.names = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.provider = new System.Windows.Forms.ComboBox();
			this.lebel7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kol)).BeginInit();
			this.SuspendLayout();
			// 
			// valit
			// 
			this.valit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.valit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.valit.FormattingEnabled = true;
			this.valit.Location = new System.Drawing.Point(128, 210);
			this.valit.Name = "valit";
			this.valit.Size = new System.Drawing.Size(669, 26);
			this.valit.TabIndex = 42;
			// 
			// price
			// 
			this.price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.price.DecimalPlaces = 2;
			this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.price.Location = new System.Drawing.Point(128, 172);
			this.price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.price.Name = "price";
			this.price.Size = new System.Drawing.Size(669, 24);
			this.price.TabIndex = 41;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 213);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 18);
			this.label5.TabIndex = 40;
			this.label5.Text = "Валюта";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 174);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 18);
			this.label6.TabIndex = 39;
			this.label6.Text = "Цена";
			// 
			// izmen
			// 
			this.izmen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.izmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.izmen.FormattingEnabled = true;
			this.izmen.Location = new System.Drawing.Point(128, 128);
			this.izmen.Name = "izmen";
			this.izmen.Size = new System.Drawing.Size(669, 26);
			this.izmen.TabIndex = 38;
			// 
			// kol
			// 
			this.kol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.kol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.kol.Location = new System.Drawing.Point(128, 90);
			this.kol.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.kol.Name = "kol";
			this.kol.Size = new System.Drawing.Size(669, 24);
			this.kol.TabIndex = 37;
			// 
			// nazad
			// 
			this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nazad.Location = new System.Drawing.Point(143, 296);
			this.nazad.Name = "nazad";
			this.nazad.Size = new System.Drawing.Size(106, 29);
			this.nazad.TabIndex = 36;
			this.nazad.Text = "Назад";
			this.nazad.UseVisualStyleBackColor = true;
			this.nazad.Click += new System.EventHandler(this.nazad_Click);
			// 
			// add_provider
			// 
			this.add_provider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.add_provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add_provider.Location = new System.Drawing.Point(15, 296);
			this.add_provider.Name = "add_provider";
			this.add_provider.Size = new System.Drawing.Size(106, 29);
			this.add_provider.TabIndex = 35;
			this.add_provider.Text = "Добавить";
			this.add_provider.UseVisualStyleBackColor = true;
			this.add_provider.Click += new System.EventHandler(this.add_provider_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 18);
			this.label4.TabIndex = 34;
			this.label4.Text = "Ед. Измерения";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 18);
			this.label3.TabIndex = 33;
			this.label3.Text = "Количество";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 18);
			this.label2.TabIndex = 32;
			this.label2.Text = "Название";
			// 
			// names
			// 
			this.names.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.names.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.names.Location = new System.Drawing.Point(128, 53);
			this.names.MaxLength = 200;
			this.names.Name = "names";
			this.names.Size = new System.Drawing.Size(669, 24);
			this.names.TabIndex = 31;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(247, 31);
			this.label1.TabIndex = 30;
			this.label1.Text = "Новый ингредиент";
			// 
			// provider
			// 
			this.provider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.provider.FormattingEnabled = true;
			this.provider.Location = new System.Drawing.Point(128, 251);
			this.provider.Name = "provider";
			this.provider.Size = new System.Drawing.Size(669, 26);
			this.provider.TabIndex = 44;
			// 
			// lebel7
			// 
			this.lebel7.AutoSize = true;
			this.lebel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lebel7.Location = new System.Drawing.Point(12, 254);
			this.lebel7.Name = "lebel7";
			this.lebel7.Size = new System.Drawing.Size(86, 18);
			this.lebel7.TabIndex = 43;
			this.lebel7.Text = "Поставщик";
			// 
			// AddIngridientControls
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.provider);
			this.Controls.Add(this.lebel7);
			this.Controls.Add(this.valit);
			this.Controls.Add(this.price);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.izmen);
			this.Controls.Add(this.kol);
			this.Controls.Add(this.nazad);
			this.Controls.Add(this.add_provider);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.names);
			this.Controls.Add(this.label1);
			this.Name = "AddIngridientControls";
			this.Size = new System.Drawing.Size(800, 426);
			((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kol)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox valit;
		private System.Windows.Forms.NumericUpDown price;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox izmen;
		private System.Windows.Forms.NumericUpDown kol;
		private System.Windows.Forms.Button nazad;
		private System.Windows.Forms.Button add_provider;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox names;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox provider;
		private System.Windows.Forms.Label lebel7;
	}
}
