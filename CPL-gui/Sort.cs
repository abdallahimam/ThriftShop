using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPL_gui
{
	public partial class Sort : Form
	{
		private List<String> items = new List<String>();
		private List<long> numbers = new List<long>();
		public Sort()
		{
			InitializeComponent();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			String text = this.tbNumber.Text;
			if (text != "")
			{
				try
				{
					long number = long.Parse(text);
					this.items.Add(text);
					this.numbers.Add(number);
					this.normalList.DataSource = null;
					this.normalList.DataSource = items;
					this.tbNumber.Clear();
					this.tbKth.Clear();
					this.tbView.Clear();
					this.normalList.SelectedIndex = numbers.ToArray().Length - 1;
				}
				catch (Exception)
				{
					throw;
				}
			}
		}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			int index = this.normalList.SelectedIndex;
			if (index >= 0)
			{
				items.RemoveAt(index);
				numbers.RemoveAt(index);
				this.normalList.DataSource = null;
				this.normalList.DataSource = items;
				this.sortedList.DataSource = null;
				this.tbView.Clear();
			}
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			this.normalList.DataSource = null;
			this.sortedList.DataSource = null;
			this.tbView.Clear();
			this.tbNumber.Clear();
			this.tbKth.Clear();
			items.Clear();
			numbers.Clear();
		}

		private void buttonFindKth_Click(object sender, EventArgs e)
		{
			int kth = int.Parse(tbKth.Text);
			int numbersSize = numbers.ToArray().Length;
			if (tbKth.Text != "" || tbKth.Text.Contains("-"))
			{
				if (kth > 0 && kth <= numbers.ToArray().Length)
				{
					long largest = FindKthLargestNumber(numbers.ToArray(), numbersSize);
					List<long> sorted = numbers.ToList();
					sorted.Sort();
					sorted.Reverse();
					this.sortedList.DataSource = sorted;
					this.tbView.Text = largest.ToString();
					this.sortedList.SelectedIndex = kth - 1;

				}
			}
		}

		private long FindKthLargestNumber(long[] numbersArray, int numbersSize)
		{
			long smallest = long.MaxValue;
			foreach (var number in numbersArray)
			{
				if (number < smallest)
				{
					smallest = number;
				}
			}
			int index;
			long large;
			int kth = int.Parse(tbKth.Text);
			tbKth.Text = "";
			for (int i = 1; i < kth; i++)
			{
				index = 0;
				large = smallest;
				for (int j = 0; j < numbersSize; j++)
				{
					if (numbersArray[j] > large)
					{
						large = numbersArray[j];
						index = j;
					}
				}
				for (int j = 0; j < numbersSize; j++)
				{
					if (numbersArray[j] == large)
					{
						numbersArray[j] = smallest;
					}
				}
			}
			long largest = smallest;
			for (int j = 0; j < numbersSize; j++)
			{
				if (numbersArray[j] > largest)
				{
					largest = numbersArray[j];
				}
			}
			return largest;
		}
	}
}
