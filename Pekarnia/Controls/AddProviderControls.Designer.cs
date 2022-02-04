namespace Pekarnia.Controls
{
	partial class AddProviderControls
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
			this.label1 = new System.Windows.Forms.Label();
			this.names = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.emails = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.add_provider = new System.Windows.Forms.Button();
			this.nazad = new System.Windows.Forms.Button();
			this.phones = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 31);
			this.label1.TabIndex = 5;
			this.label1.Text = "Новый поставщик";
			// 
			// names
			// 
			this.names.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.names.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.names.Location = new System.Drawing.Point(93, 50);
			this.names.MaxLength = 200;
			this.names.Name = "names";
			this.names.Size = new System.Drawing.Size(704, 24);
			this.names.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "Название";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "Email";
			// 
			// emails
			// 
			this.emails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.emails.Location = new System.Drawing.Point(93, 86);
			this.emails.MaxLength = 200;
			this.emails.Name = "emails";
			this.emails.Size = new System.Drawing.Size(704, 24);
			this.emails.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 18);
			this.label4.TabIndex = 10;
			this.label4.Text = "Телефон";
			// 
			// add_provider
			// 
			this.add_provider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.add_provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add_provider.Location = new System.Drawing.Point(15, 172);
			this.add_provider.Name = "add_provider";
			this.add_provider.Size = new System.Drawing.Size(106, 29);
			this.add_provider.TabIndex = 12;
			this.add_provider.Text = "Добавить";
			this.add_provider.UseVisualStyleBackColor = true;
			this.add_provider.Click += new System.EventHandler(this.add_provider_Click);
			// 
			// nazad
			// 
			this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nazad.Location = new System.Drawing.Point(143, 172);
			this.nazad.Name = "nazad";
			this.nazad.Size = new System.Drawing.Size(106, 29);
			this.nazad.TabIndex = 13;
			this.nazad.Text = "Назад";
			this.nazad.UseVisualStyleBackColor = true;
			this.nazad.Click += new System.EventHandler(this.nazad_Click);
			// 
			// phones
			// 
			this.phones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.phones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.phones.Location = new System.Drawing.Point(93, 125);
			this.phones.Mask = "+7 (999) 999 99 99";
			this.phones.Name = "phones";
			this.phones.Size = new System.Drawing.Size(704, 24);
			this.phones.TabIndex = 14;
			// 
			// AddProviderControls
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.phones);
			this.Controls.Add(this.nazad);
			this.Controls.Add(this.add_provider);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.emails);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.names);
			this.Controls.Add(this.label1);
			this.Name = "AddProviderControls";
			this.Size = new System.Drawing.Size(800, 426);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox names;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox emails;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button add_provider;
		private System.Windows.Forms.Button nazad;
		private System.Windows.Forms.MaskedTextBox phones;
	}
}
