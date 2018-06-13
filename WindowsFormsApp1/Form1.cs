using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var totalCount = 50000;

            var matchingCount = 0;

            var rnd = new Random();
            int[] template = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < totalCount; i++)
            {

                var final = new List<int>();
                var lst = new List<int>(template);

                for (int j = 0; j < 5; j++)
                {
                    int index = rnd.Next(0, lst.Count);
                    final.Add(lst[index]);
                    lst.RemoveAt(index);
                }

                int oddCount = final.Count(p => p % 2 == 1);
                if (oddCount==2)
                {
                    bool firstOdd = (final[0] % 2 == 1);
                    bool secondOdd = (final[2] % 2 == 1);
                    bool thirdOdd = (final[4] % 2 == 1);
                    if (firstOdd && secondOdd || firstOdd && thirdOdd || secondOdd && thirdOdd) matchingCount += 1;
                }
            }

            var result = matchingCount * 1.0 / totalCount;

            System.Diagnostics.Debug.Print($"{result}");
        }
    }
}
