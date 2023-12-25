using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Быки_и_коровы
{
	public partial class Game : Form
	{
		string secret_number;

		public Game()
		{
			InitializeComponent();
			secret_number = new Random().Next(1000, 10000).ToString();
		}

		private void Add_Result(string result)
		{
			listView1.Items.Add(new ListViewItem(new string[] { tbNumber.Text, result }));
		}

		private bool Check_Win()
		{
			return tbNumber.Text == secret_number;
		}

		private bool Check_Bull()
		{
			return new List<int>() { 0, 1, 2, 3 }.Any(x => secret_number[x] == tbNumber.Text[x]);
		}

		private bool Check_Cow()
		{
			return tbNumber.Text.Any(x => secret_number.Contains(x));
		}

		private void Check_Number()
		{
			if (Check_Win()) Add_Result("Победа!");
			else if (Check_Bull()) Add_Result("Бык");
			else if (Check_Cow()) Add_Result("Корова");
			else Add_Result("Мимо");
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (tbNumber.Text == string.Empty || !int.TryParse(tbNumber.Text, out _) || tbNumber.Text[0] == '0' || tbNumber.Text.Length != 4)
				MessageBox.Show("Неверный ввод!");

			else Check_Number();
		}
	}
}
