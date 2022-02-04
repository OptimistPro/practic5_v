namespace Pekarnia.Controls
{
	partial class ProviderControls
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.table = new System.Windows.Forms.DataGridView();
			this.ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.names = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Close_controls = new System.Windows.Forms.Label();
			this.new_provider = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Поставщики";
			// 
			// table
			// 
			this.table.AllowUserToAddRows = false;
			this.table.AllowUserToDeleteRows = false;
			this.table.AllowUserToResizeColumns = false;
			this.table.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.table.BackgroundColor = System.Drawing.SystemColors.Control;
			this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ids,
            this.names,
            this.Email,
            this.Phone});
			this.table.EnableHeadersVisualStyles = false;
			this.table.Location = new System.Drawing.Point(15, 44);
			this.table.Name = "table";
			this.table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.table.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.table.RowHeadersVisible = false;
			this.table.Size = new System.Drawing.Size(770, 351);
			this.table.TabIndex = 1;
			this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
			// 
			// ids
			// 
			this.ids.HeaderText = "id";
			this.ids.Name = "ids";
			this.ids.Visible = false;
			// 
			// names
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.names.DefaultCellStyle = dataGridViewCellStyle3;
			this.names.HeaderText = "Название";
			this.names.Name = "names";
			// 
			// Email
			// 
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Email.DefaultCellStyle = dataGridViewCellStyle4;
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			// 
			// Phone
			// 
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Phone.DefaultCellStyle = dataGridViewCellStyle5;
			this.Phone.HeaderText = "Телефон";
			this.Phone.Name = "Phone";
			// 
			// Close_controls
			// 
			this.Close_controls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Close_controls.AutoSize = true;
			this.Close_controls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Close_controls.Location = new System.Drawing.Point(759, 16);
			this.Close_controls.Name = "Close_controls";
			this.Close_controls.Size = new System.Drawing.Size(26, 25);
			this.Close_controls.TabIndex = 2;
			this.Close_controls.Text = "Х";
			this.Close_controls.Click += new System.EventHandler(this.Close_controls_Click);
			// 
			// new_provider
			// 
			this.new_provider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.new_provider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.new_provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_provider.Location = new System.Drawing.Point(666, 13);
			this.new_provider.Name = "new_provider";
			this.new_provider.Size = new System.Drawing.Size(87, 28);
			this.new_provider.TabIndex = 3;
			this.new_provider.Text = "Добавить";
			this.new_provider.UseVisualStyleBackColor = true;
			this.new_provider.Click += new System.EventHandler(this.new_provider_Click);
			// 
			// ProviderControls
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.new_provider);
			this.Controls.Add(this.Close_controls);
			this.Controls.Add(this.table);
			this.Controls.Add(this.label1);
			this.Name = "ProviderControls";
			this.Size = new System.Drawing.Size(800, 426);
			((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView table;
		private System.Windows.Forms.Label Close_controls;
		private System.Windows.Forms.Button new_provider;
		private System.Windows.Forms.DataGridViewTextBoxColumn ids;
		private System.Windows.Forms.DataGridViewTextBoxColumn names;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
	}
}
