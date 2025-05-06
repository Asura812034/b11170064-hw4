using System;
using System.Windows.Forms;

namespace ArraySortingApp
{
    public class MainForm : Form
    {
        private Label resultLabel;

        public MainForm()
        {
            // 初始化表單
            this.Text = "Array Sorting Example";
            this.Size = new System.Drawing.Size(400, 300);

            // 初始化標籤控制項
            resultLabel = new Label();
            resultLabel.AutoSize = true;
            resultLabel.Location = new System.Drawing.Point(20, 20);
            resultLabel.Font = new System.Drawing.Font("Arial", 12);
            this.Controls.Add(resultLabel);

            // 呼叫方法
            DisplaySortedArray();
        }

        private void DisplaySortedArray()
        {
            // 宣告一維陣列
            int[] numbers = new int[5];

            // 使用亂數類別來產生陣列的元素值
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 201); // 產生範圍為 1~200 的整數
            }

            // 排序陣列
            Array.Sort(numbers);

            // 顯示結果
            resultLabel.Text = "Sorted Array: " + string.Join(", ", numbers);
        }
    }
}