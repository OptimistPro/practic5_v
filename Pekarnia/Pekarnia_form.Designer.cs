namespace Pekarnia
{
	partial class pekarnia_form
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.provider_buttom = new System.Windows.Forms.ToolStripMenuItem();
			this.goods_buttom = new System.Windows.Forms.ToolStripMenuItem();
			this.ingridients_buttom = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.provider_buttom,
            this.goods_buttom,
            this.ingridients_buttom});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// provider_buttom
			// 
			this.provider_buttom.Name = "provider_buttom";
			this.provider_buttom.Size = new System.Drawing.Size(89, 20);
			this.provider_buttom.Text = "Поставщики";
			this.provider_buttom.Click += new System.EventHandler(this.provider_buttom_Click);
			// 
			// goods_buttom
			// 
			this.goods_buttom.Name = "goods_buttom";
			this.goods_buttom.Size = new System.Drawing.Size(74, 20);
			this.goods_buttom.Text = "Продукты";
			this.goods_buttom.Click += new System.EventHandler(this.goods_buttom_Click);
			// 
			// ingridients_buttom
			// 
			this.ingridients_buttom.Name = "ingridients_buttom";
			this.ingridients_buttom.Size = new System.Drawing.Size(93, 20);
			this.ingridients_buttom.Text = "Ингредиенты";
			this.ingridients_buttom.Click += new System.EventHandler(this.ingridients_buttom_Click);
			// 
			// pekarnia_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "pekarnia_form";
			this.Text = "Пекарня";
			this.SizeChanged += new System.EventHandler(this.pekarnia_form_SizeChanged);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem provider_buttom;
		private System.Windows.Forms.ToolStripMenuItem goods_buttom;
		private System.Windows.Forms.ToolStripMenuItem ingridients_buttom;
	}
}

