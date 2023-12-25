namespace Быки_и_коровы
{
	partial class Game
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tbNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Result});
			this.listView1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(34, 26);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(246, 412);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// Number
			// 
			this.Number.Text = "Число";
			this.Number.Width = 80;
			// 
			// Result
			// 
			this.Result.Text = "Результат";
			this.Result.Width = 100;
			// 
			// tbNumber
			// 
			this.tbNumber.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbNumber.Location = new System.Drawing.Point(348, 75);
			this.tbNumber.Name = "tbNumber";
			this.tbNumber.Size = new System.Drawing.Size(177, 32);
			this.tbNumber.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(343, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Введите число";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAdd.Location = new System.Drawing.Point(348, 127);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(169, 41);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(325, 190);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(211, 248);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "Заметки";
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(558, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbNumber);
			this.Controls.Add(this.listView1);
			this.Name = "Game";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Быки и коровы";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		public System.Windows.Forms.ColumnHeader Number;
		public System.Windows.Forms.ColumnHeader Result;
		private System.Windows.Forms.TextBox tbNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox textBox1;
	}
}

