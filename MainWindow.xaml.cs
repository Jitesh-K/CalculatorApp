using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n2000 = 0, n500 = 0, n100 = 0, n50 = 0, n10 = 0,n20=0, n5 = 0;
        int c10 = 0, c5 = 0, c2 = 0, c1 = 0,cR=0;
        int previousValue = 0;
        public MainWindow()
        {
            InitializeComponent();
            textBox1.Focus(); // Focus on this textbox on startup
            

        }


        #region Final Calculation

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Calculate total amount

            try
            {
                label14.Content = Convert.ToInt32(label7.Content) +  //Previous Value
                                      Convert.ToInt32(label8.Content) +  // 2000
                                      Convert.ToInt32(label9.Content) +  // 500
                                      Convert.ToInt32(label10.Content) + // 100
                                      Convert.ToInt32(label11.Content) + // 50
                                      Convert.ToInt32(label27.Content) + // 20 
                                      Convert.ToInt32(label12.Content) + // 10
                                      Convert.ToInt32(label13.Content) + // 5
                                      Convert.ToInt32(label21.Content) + // 10 Coins
                                      Convert.ToInt32(label29.Content); // coins rest

                // Convert total amount to words , call to Convert.cs class
                textBlock.Text = NumbersToWords(Convert.ToInt32(label14.Content));

            }
            catch (Exception)
            {
                MessageBox.Show("Some Error Occured , Contact System Admin");
            }
        } 
        #endregion


        #region Notes
        // Previous Value
        /// <summary>
        ///  if (textBox.Text != "") - so that label assigns to 0 when empty ontextchange event 
         ///   {
            ///    bool check = Int32.TryParse(textBox.Text, out previousValue); // to check if only int is input
              ///  if (check != false)
                 ///   label7.Content = previousValue;
               /// else
                ///{
                  ///  MessageBox.Show("Input Invalid"); // assign default if false
                    ///textBox.Text = "";
                    ///label7.Content = 0;
                ///}
///}
            ///else
            ///{
              ///  label7.Content = 0;
            ///}
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            //previous value
            if (textBox.Text != "")
            {
                bool check = Int32.TryParse(textBox.Text, out previousValue);
                if (check != false)
                    label7.Content = previousValue;
                else
                {
                    MessageBox.Show("Input Invalid");
                    textBox.Text = "";
                    label7.Content = 0;
                }
            }
            else
            {
                label7.Content = 0;
            }
        }

        // 2000 Note
        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //2000
            if (textBox1.Text != "")
            {
                bool check = Int32.TryParse(textBox1.Text, out n2000);
                if (check != false)
                {
                    label8.Content = n2000 * 2000;
                    //  a2000 =Convert.ToInt32(label8.Content);
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                    textBox1.Text = "";
                    label8.Content = 0;
                }
            }
            else
            {
                label8.Content = 0;
            }
        }
        // 500 Note
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            //500
            if (textBox2.Text != "")
            {
                bool check = Int32.TryParse(textBox2.Text, out n500);
                if (check != false)
                {
                    label9.Content = n500 * 500;
                    //  a500 = Convert.ToInt32(label9.Content);
                }
                else
                {
                    MessageBox.Show("Input Invalid");
                    textBox2.Text = "";
                    label9.Content = 0;
                }
            }
            else
            {
                label9.Content = 0;
            }
        }



        // 1000 Note
        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            //100
            if (textBox3.Text != "")
            {
                bool check = Int32.TryParse(textBox3.Text, out n100);
                if (check != false)
                {
                    label10.Content = n100 * 100;
                    //  a100 = Convert.ToInt32(label10.Content);
                }

                else
                {
                    MessageBox.Show("Input Invalid");
                    textBox3.Text = "";
                    label10.Content = 0;
                }
            }
            else
            {
                label10.Content = 0;
            }

        }

        // 500 Note
        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            //50
            if (textBox4.Text != "")
            {
                bool check = Int32.TryParse(textBox4.Text, out n50);
                if (check != false)
                {
                    label11.Content = n50 * 50;
                    //  a50 = Convert.ToInt32(label11.Content);
                }
                else
                {
                    MessageBox.Show("Input Invalid");
                    textBox4.Text = "";
                    label11.Content = 0;
                }

            }
            else
            {
                label11.Content = 0;
            }
        }

        // 20 Note
        private void textBox11_TextChanged(object sender, TextChangedEventArgs e)
        {
            //20
            if (textBox11.Text != "")
            {
                bool check = Int32.TryParse(textBox11.Text, out n20);
                if (check != false)
                {
                    label27.Content = n20 * 20;
                    //  a100 = Convert.ToInt32(label10.Content);
                }

                else
                {
                    MessageBox.Show("Input Invalid");
                    textBox11.Text = "";
                    label27.Content = 0;
                }
            }
            else
            {
                label10.Content = 0;
            }
        }

        // 10 Note
        private void textBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            //10
            if (textBox5.Text != "")
            {
                bool check = Int32.TryParse(textBox5.Text, out n10);
                if (check != false)
                {
                    label12.Content = n10 * 10;
                    //   a10 = Convert.ToInt32(label12.Content);
                }
                else
                {
                    MessageBox.Show("Input Invalid");
                    textBox5.Text = "";
                    label12.Content = 0;
                }
            }
            else
            {
                label12.Content = 0;
            }
        }

        // 5 Note
        private void textBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            //5
            if (textBox6.Text != "")
            {
                bool check = Int32.TryParse(textBox6.Text, out n5);

                if (check != false)
                {
                    label13.Content = n5 * 5;
                    //  a5 = Convert.ToInt32(label13.Content);
                }
                else
                {
                    MessageBox.Show("Input Invalid");
                    textBox6.Text = "";
                    label13.Content = 0;
                }
            }
            else
            {
                label13.Content = 0;
            }


        }

        #endregion


        #region Coins

        // 10 Coin
        private void textBox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            //10
            if (textBox7.Text != "")
            {
                bool check = Int32.TryParse(textBox7.Text, out c10);

                if (check != false)
                {
                    label21.Content = c10 ;
                    //  a5 = Convert.ToInt32(label13.Content);
                }
                else
                {
                    MessageBox.Show("Input Invalid");
                    textBox7.Text = "";
                    label21.Content = 0;
                }
            }
            else
            {
                label21.Content = 0;
            }
        }

        // Rest Coins
        private void textBox12_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Rest Coins 
            if (textBox12.Text != "")
            {
                bool check = Int32.TryParse(textBox12.Text, out cR);

                if (check != false)
                {
                    label29.Content = cR;
                    //  a5 = Convert.ToInt32(label13.Content);
                }
                else
                {
                    MessageBox.Show("Input Invalid");
                    textBox12.Text = "";
                    label29.Content = 0;
                }
            }
            else
            {
                label29.Content = 0;
            }
        }

        // 5 Coin , Not Used
        private void textBox8_TextChanged(object sender, TextChangedEventArgs e)
        {
            //5
            if (textBox8.Text != "")
            {
                bool check = Int32.TryParse(textBox8.Text, out c5);

                if (check != false)
                {
                    label22.Content = c5 * 5;
                    //  a5 = Convert.ToInt32(label13.Content);
                }
                else
                {
                    MessageBox.Show("Input Invalid");
                    textBox8.Text = "";
                    label22.Content = 0;
                }
            }
            else
            {
                label22.Content = 0;
            }
        }

        // 2 Coin , Not Used
        private void textBox9_TextChanged(object sender, TextChangedEventArgs e)
        {
            //2
            if (textBox9.Text != "")
            {
                bool check = Int32.TryParse(textBox9.Text, out c2);

                if (check != false)
                {
                    label23.Content = c2 * 2;
                    //  a5 = Convert.ToInt32(label13.Content);
                }
                else
                {
                    MessageBox.Show("Input Invalid");
                    textBox9.Text = "";
                    label23.Content = 0;
                }
            }
            else
            {
                label23.Content = 0;
            }
        }

        // 1 Coin , Not Used
        private void textBox10_TextChanged(object sender, TextChangedEventArgs e)
        {
            //1
            if (textBox10.Text != "")
            {
                bool check = Int32.TryParse(textBox10.Text, out c1);

                if (check != false)
                {
                    label24.Content = c1 * 1;  
                    //  a5 = Convert.ToInt32(label13.Content);
                }
                else
                {
                    MessageBox.Show("Input Invalid");
                    textBox10.Text = "";
                    label24.Content = 0;
                }
            }
            else
            {
                label24.Content = 0;
            }
        }
        #endregion


        #region Code to Switch between textboxes on pressing ENTER
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                textBox1.Focus();
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                textBox2.Focus();
                e.Handled = true;
            }
        }

      

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                textBox3.Focus();
                e.Handled = true;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                textBox4.Focus();
                e.Handled = true;
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                textBox11.Focus();
                e.Handled = true;
            }
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                textBox5.Focus();
                e.Handled = true;
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                textBox6.Focus();
                e.Handled = true;
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                textBox7.Focus();
                e.Handled = true;
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                textBox12.Focus();
                e.Handled = true;
            }
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                button.Focus();
                e.Handled = true;
            }
        }

        // Clear all text on pressing down key after calculate
        private void button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                textBox.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();

                label27.Content = 0;   // clear labels
                label14.Content = "";
                textBlock.Text = "";

                textBox1.Focus();  // focus on 1st textbox

                e.Handled = true;
            }
        }
        #endregion


        #region CovertFromNumberToWords

        // Unused code
        public static string ConvertNumbertoWords(int number)
        {
            if (number == 0) return "ZERO";
            if (number < 0) return "minus " + ConvertNumbertoWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000) > 0)
            {
                words += ConvertNumbertoWords(number / 100000) + " LAKHS ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
                number %= 100;
            }
            //if ((number / 10) > 0)  
            //{  
            // words += ConvertNumbertoWords(number / 10) + " RUPEES ";  
            // number %= 10;  
            //}  
            if (number > 0)
            {
                if (words != "") words += "AND ";
                var unitsMap = new[]
                {
            "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"
        };
                var tensMap = new[]
                {
            "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"
        };
                if (number < 20) words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0) words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }


        public static string NumbersToWords(int inputNumber)
        {
            int inputNo = inputNumber;
            if (inputNo == 0)
                return "Zero";
            int[] numbers = new int[4];
            int first = 0;
            int u, h, t;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (inputNo < 0)
            {
                sb.Append("Minus");
                inputNo = -inputNo;
            }
            string[] words0 = {"" ," One "," Two "," Three "," Four ",
           " Five " ," Six "," Seven "," Eight "," Nine "};
            string[] words1 = {" Ten "," Eleven "," Twelve "," Thirteen "," Fourteen ",
           " Fifteen "," Sixteen "," Seventeen "," Eighteen "," Nineteen "};
            string[] words2 = {" Twenty "," Thirty "," Forty "," Fifty "," Sixty ",
           " Seventy "," Eighty "," Ninety "};
            string[] words3 = {" Thousand "," Lakh "," Crore " };
            numbers[0] = inputNo % 1000; // units
            numbers[1] = inputNo / 1000;
            numbers[2] = inputNo / 100000;
            numbers[1] = numbers[1] - 100 * numbers[2]; // thousands
            numbers[3] = inputNo / 10000000; // crores
            numbers[2] = numbers[2] - 100 * numbers[3]; // lakhs
            for (int i = 3; i > 0; i--)
            {
                if (numbers[i] != 0)
                {
                    first = i;
                    break;
                }
            }
            for (int i = first; i >= 0; i--)
            {
                if (numbers[i] == 0) continue;
                u = numbers[i] % 10; // ones
                t = numbers[i] / 10;
                h = numbers[i] / 100; // hundreds
                t = t - 10 * h; // tens
                if (h > 0) sb.Append(words0[h] +" Hundred ");
                if (u > 0 || t > 0)
                {
                    if (h > 0 || i == 0) sb.Append(" and ");
                    if (t == 0)
                        sb.Append(words0[u]);
                    else if (t == 1)
                        sb.Append(words1[u]);
                    else
                        sb.Append(words2[t - 2] + words0[u]);
                }
                if (i != 0) sb.Append(words3[i - 1]);
            }
            return sb.ToString().TrimEnd();
        }
        #endregion
    }
}
