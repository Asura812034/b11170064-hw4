using System;
using System.Windows.Forms;

namespace TextSearchAndSortApp
{
    public class MainForm : Form
    {
        private TextBox inputTextBox;
        private TextBox searchTextBox;
        private Button sortButton;
        private Button searchButton;
        private Label resultLabel;

        public MainForm()
        {
            // 初始化表單
            this.Text = "Text Search and Sort";
            this.Size = new System.Drawing.Size(500, 300);

            // 初始化輸入文字方塊
            inputTextBox = new TextBox();
            inputTextBox.Location = new System.Drawing.Point(20, 20);
            inputTextBox.Width = 400;
            this.Controls.Add(inputTextBox);

            // 初始化搜尋文字方塊
            searchTextBox = new TextBox();
            searchTextBox.Location = new System.Drawing.Point(20, 60);
            searchTextBox.Width = 100;
            this.Controls.Add(searchTextBox);

            // 初始化排序按鈕
            sortButton = new Button();
            sortButton.Text = "Sort";
            sortButton.Location = new System.Drawing.Point(20, 100);
            sortButton.Click += SortButton_Click;
            this.Controls.Add(sortButton);

            // 初始化搜尋按鈕
            searchButton = new Button();
            searchButton.Text = "Search";
            searchButton.Location = new System.Drawing.Point(120, 100);
            searchButton.Click += SearchButton_Click;
            this.Controls.Add(searchButton);

            // 初始化結果標籤
            resultLabel = new Label();
            resultLabel.AutoSize = true;
            resultLabel.Location = new System.Drawing.Point(20, 140);
            this.Controls.Add(resultLabel);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            char[] charArray = input.ToCharArray();

            // 使用泡沫排序法對字串排序
            BubbleSort(charArray);

            string sortedString = new string(charArray);
            resultLabel.Text = "Sorted: " + sortedString;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            char[] charArray = input.ToCharArray();

            // 使用泡沫排序法對字串排序
            BubbleSort(charArray);

            string sortedString = new string(charArray);
            char searchChar = searchTextBox.Text.Length > 0 ? searchTextBox.Text[0] : '\0';

            // 使用二元搜尋法
            int index = BinarySearch(charArray, searchChar);
            if (index != -1)
            {
                resultLabel.Text = $"Character '{searchChar}' found at index {index}.";
            }
            else
            {
                resultLabel.Text = $"Character '{searchChar}' not found.";
            }
        }

        private void BubbleSort(char[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // 交換元素
                        char temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        private int BinarySearch(char[] array, char target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }
                if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // 未找到
        }
    }
}