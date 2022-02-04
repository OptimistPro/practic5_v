﻿namespace Pekarnia.Controls
{
	partial class UpdateIngridientsControls
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
			this.provider = new System.Windows.Forms.ComboBox();
			this.lebel7 = new System.Windows.Forms.Label();
			this.valit = new System.Windows.Forms.ComboBox();
			this.price = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.izmen = new System.Windows.Forms.ComboBox();
			this.kol = new System.Windows.Forms.NumericUpDown();
			this.nazad = new System.Windows.Forms.Button();
			this.update_provider = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.names = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.delete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kol)).BeginInit();
			this.SuspendLayout();
			// 
			// provider
			// 
			this.provider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.provider.FormattingEnabled = true;
			this.provider.Location = new System.Drawing.Point(128, 247);
			this.provider.Name = "provider";
			this.provider.Size = new System.Drawing.Size(669, 26);
			this.provider.TabIndex = 59;
			// 
			// lebel7
			// 
			this.lebel7.AutoSize = true;
			this.lebel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lebel7.Location = new System.Drawing.Point(12, 250);
			this.lebel7.Name = "lebel7";
			this.lebel7.Size = new System.Drawing.Size(86, 18);
			this.lebel7.TabIndex = 58;
			this.lebel7.Text = "Поставщик";
			// 
			// valit
			// 
			this.valit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.valit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.valit.FormattingEnabled = true;
			this.valit.Location = new System.Drawing.Point(128, 206);
			this.valit.Name = "valit";
			this.valit.Size = new System.Drawing.Size(669, 26);
			this.valit.TabIndex = 57;
			// 
			// price
			// 
			this.price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.price.DecimalPlaces = 2;
			this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.price.Location = new System.Drawing.Point(128, 168);
			this.price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.price.Name = "price";
			this.price.Size = new System.Drawing.Size(669, 24);
			this.price.TabIndex = 56;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 209);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 18);
			this.label5.TabIndex = 55;
			this.label5.Text = "Валюта";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 18);
			this.label6.TabIndex = 54;
			this.label6.Text = "Цена";
			// 
			// izmen
			// 
			this.izmen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.izmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.izmen.FormattingEnabled = true;
			this.izmen.Location = new System.Drawing.Point(128, 124);
			this.izmen.Name = "izmen";
			this.izmen.Size = new System.Drawing.Size(669, 26);
			this.izmen.TabIndex = 53;
			// 
			// kol
			// 
			this.kol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.kol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.kol.Location = new System.Drawing.Point(128, 86);
			this.kol.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.kol.Name = "kol";
			this.kol.Size = new System.Drawing.Size(669, 24);
			this.kol.TabIndex = 52;
			// 
			// nazad
			// 
			this.nazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nazad.Location = new System.Drawing.Point(691, 292);
			this.nazad.Name = "nazad";
			this.nazad.Size = new System.Drawing.Size(106, 29);
			this.nazad.TabIndex = 51;
			this.nazad.Text = "Назад";
			this.nazad.UseVisualStyleBackColor = true;
			this.nazad.Click += new System.EventHandler(this.nazad_Click);
			// 
			// update_provider
			// 
			this.update_provider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.update_provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.update_provider.Location = new System.Drawing.Point(15, 292);
			this.update_provider.Name = "update_provider";
			this.update_provider.Size = new System.Drawing.Size(106, 29);
			this.update_provider.TabIndex = 50;
			this.update_provider.Text = "Обновить";
			this.update_provider.UseVisualStyleBackColor = true;
			this.update_provider.Click += new System.EventHandler(this.update_provider_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 18);
			this.label4.TabIndex = 49;
			this.label4.Text = "Ед. Измерения";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 18);
			this.label3.TabIndex = 48;
			this.label3.Text = "Количество";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 18);
			this.label2.TabIndex = 47;
			this.label2.Text = "Название";
			// 
			// names
			// 
			this.names.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.names.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.names.Location = new System.Drawing.Point(128, 49);
			this.names.MaxLength = 200;
			this.names.Name = "names";
			this.names.Size = new System.Drawing.Size(669, 24);
			this.names.TabIndex = 46;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 31);
			this.label1.TabIndex = 45;
			this.label1.Text = "Ингредиент";
			// 
			// delete
			// 
			this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.delete.Location = new System.Drawing.Point(143, 292);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(106, 29);
			this.delete.TabIndex = 60;
			this.delete.Text = "Удалить";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// UpdateIngridientsControls
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.delete);
			this.Controls.Add(this.provider);
			this.Controls.Add(this.lebel7);
			this.Controls.Add(this.valit);
			this.Controls.Add(this.price);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.izmen);
			this.Controls.Add(this.kol);
			this.Controls.Add(this.nazad);
			this.Controls.Add(this.update_provider);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.names);
			this.Controls.Add(this.label1);
			this.Name = "UpdateIngridientsControls";
			this.Size = new System.Drawing.Size(800, 426);
			((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kol)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox provider;
		private System.Windows.Forms.Label lebel7;
		private System.Windows.Forms.ComboBox valit;
		private System.Windows.Forms.NumericUpDown price;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox izmen;
		private System.Windows.Forms.NumericUpDown kol;
		private System.Windows.Forms.Button nazad;
		private System.Windows.Forms.Button update_provider;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox names;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button delete;
	}
}
