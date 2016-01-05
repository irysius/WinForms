using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			InitializeTextboxes();
			textboxes[0].Text = "Hello World";
			textboxes[5].Text = "110.00";
		}

		List<TextBox> textboxes = new List<TextBox>();
		public void InitializeTextboxes()
		{
			for (int i = 0; i < 100; ++i)
			{
				var textbox = new TextBox();
				textbox.Left = 100;
				textbox.Height = 20;
				textbox.Top = i * 20;
				textbox.Parent = this;
				textbox.Text = i.ToString();
				textbox.TextChanged += textbox_TextChanged;
				textbox.Click += textbox_Click;
				textboxes.Add(textbox);
			}
		}

		private void textbox_Click(object sender, EventArgs e)
		{
			var textbox = (TextBox)sender;
			decimal result;
			if (Decimal.TryParse(textbox.Text, out result))
			{
				result += 1;
				textbox.Text = result.ToString();
			}
		}

		private void textbox_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			decimal result;
			if (Decimal.TryParse(textboxes[5].Text, out result))
			{
				result += 1;
				textboxes[5].Text = result.ToString();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var list = textboxes.Skip(3).Take(3);
			foreach (var item in list)
			{
				item.BackColor = Color.Red;
			}
		}
	}
}
