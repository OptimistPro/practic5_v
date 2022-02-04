namespace Pekarnia.Controls
{
	partial class UbdateProviderControls
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
			this.phones = new System.Windows.Forms.MaskedTextBox();
			this.nazad = new System.Windows.Forms.Button();
			this.ubdates_provider = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.emails = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.names = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.delete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// phones
			// 
			this.phones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.phones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.phones.Location = new System.Drawing.Point(93, 123);
			this.phones.Mask = "+7 (999) 999 99 99";
			this.phones.Name = "phones";
			this.phones.Size = new System.Drawing.Size(704, 24);
			this.phones.TabIndex = 23;
			// 
			// nazad
			// 
			this.nazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nazad.Location = new System.Drawing.Point(691, 170);
			this.nazad.Name = "nazad";
			this.nazad.Size = new System.Drawing.Size(106, 29);
			this.nazad.TabIndex = 22;
			this.nazad.Text = "Назад";
			this.nazad.UseVisualStyleBackColor = true;
			this.nazad.Click += new System.EventHandler(this.nazad_Click);
			// 
			// ubdates_provider
			// 
			this.ubdates_provider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ubdates_provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ubdates_provider.Location = new System.Drawing.Point(15, 170);
			this.ubdates_provider.Name = "ubdates_provider";
			this.ubdates_provider.Size = new System.Drawing.Size(106, 29);
			this.ubdates_provider.TabIndex = 21;
			this.ubdates_provider.Text = "Обновить";
			this.ubdates_provider.UseVisualStyleBackColor = true;
			this.ubdates_provider.Click += new System.EventHandler(this.ubdates_provider_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 18);
			this.label4.TabIndex = 20;
			this.label4.Text = "Телефон";
			// 
			// emails
			// 
			this.emails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.emails.Location = new System.Drawing.Point(93, 84);
			this.emails.MaxLength = 200;
			this.emails.Name = "emails";
			this.emails.Size = new System.Drawing.Size(704, 24);
			this.emails.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 18);
			this.label3.TabIndex = 18;
			this.label3.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 18);
			this.label2.TabIndex = 17;
			this.label2.Text = "Название";
			// 
			// names
			// 
			this.names.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.names.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.names.Location = new System.Drawing.Point(93, 48);
			this.names.MaxLength = 200;
			this.names.Name = "names";
			this.names.Size = new System.Drawing.Size(704, 24);
			this.names.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 31);
			this.label1.TabIndex = 15;
			this.label1.Text = "Поставщик";
			// 
			// delete
			// 
			this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.delete.Location = new System.Drawing.Point(138, 170);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(106, 29);
			this.delete.TabIndex = 24;
			this.delete.Text = "Удалить";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// UbdateProviderControls
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.delete);
			this.Controls.Add(this.phones);
			this.Controls.Add(this.nazad);
			this.Controls.Add(this.ubdates_provider);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.emails);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.names);
			this.Controls.Add(this.label1);
			this.Name = "UbdateProviderControls";
			this.Size = new System.Drawing.Size(800, 426);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox phones;
		private System.Windows.Forms.Button nazad;
		private System.Windows.Forms.Button ubdates_provider;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox emails;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox names;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button delete;
	}
}
