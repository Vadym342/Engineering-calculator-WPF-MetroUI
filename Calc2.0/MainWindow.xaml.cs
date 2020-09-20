using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Calc2._0
{

    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                input.Text += 1;

                if (input.Text == "1")
                {
                    point.IsEnabled = true;
                }
                else
                if (input.Text.Length == ',')
                {
                    point.IsEnabled = false;
                }
                else
                {
                    if (input.Text.Length != ',')
                    {

                    }
                    else point.IsEnabled = false;
                }


            }
            catch (Exception d)
            {
               
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            input.Text += 2;
            
            if(input.Text=="2")
            {
                point.IsEnabled = true;
            }else
            if (input.Text.Length == ',')
            {
                point.IsEnabled = false;
            }
            else
            {
                if (input.Text.Length != ',')
                {
                    
                }
                else point.IsEnabled = false;
            }
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            input.Text += 3;
           
            if (input.Text == "3")
            {
                point.IsEnabled = true;
            }
            else
            if (input.Text.Length == ',')
            {
                point.IsEnabled = false;
            }
            else
            {
                if (input.Text.Length != ',')
                {

                }
                else point.IsEnabled = false;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            input.Text += 5;

            if (input.Text == "5")
            {
                point.IsEnabled = true;
            }
            else
            if (input.Text.Length == ',')
            {
                point.IsEnabled = false;
            }
            else
            {
                if (input.Text.Length != ',')
                {

                }
                else point.IsEnabled = false;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            input.Text += 4;

            if (input.Text == "4")
            {
                point.IsEnabled = true;
            }
            else
            if (input.Text.Length == ',')
            {
                point.IsEnabled = false;
            }
            else
            {
                if (input.Text.Length != ',')
                {

                }
                else point.IsEnabled = false;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            input.Text += 6;

            if (input.Text == "6")
            {
                point.IsEnabled = true;
            }
            else
            if (input.Text.Length == ',')
            {
                point.IsEnabled = false;
            }
            else
            {
                if (input.Text.Length != ',')
                {

                }
                else point.IsEnabled = false;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            input.Text += 7;

            if (input.Text == "7")
            {
                point.IsEnabled = true;
            }
            else
            if (input.Text.Length == ',')
            {
                point.IsEnabled = false;
            }
            else
            {
                if (input.Text.Length != ',')
                {

                }
                else point.IsEnabled = false;
            }

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            input.Text += 8;

            if (input.Text == "8")
            {
                point.IsEnabled = true;
            }
            else
            if (input.Text.Length == ',')
            {
                point.IsEnabled = false;
            }
            else
            {
                if (input.Text.Length != ',')
                {

                }
                else point.IsEnabled = false;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            input.Text += 9;

            if (input.Text == "9")
            {
                point.IsEnabled = true;
            }
            else
            if (input.Text.Length == ',')
            {
                point.IsEnabled = false;
            }
            else
            {
                if (input.Text.Length != ',')
                {

                }
                else point.IsEnabled = false;
            }
        }
        
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            input.Text += 0;
           
            if (input.Text == "0")
            {
               
                point.IsEnabled = true;
            }
            else
            if (input.Text.Length == ',')
            {
               
                point.IsEnabled = false;
            }
            else
            {
                if (input.Text.Length != ',')
                {
                   
                }
                else point.IsEnabled = false;
               
            }
        }
        public decimal a, b;
        public string count;
        double num2;
        public bool znakk = true;
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
        
            try
            {
                count = "+";

                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {
                   
                    a = decimal.Parse(input.Text);
                  
                }
                if (input.Text != "")
                {

                    minus.IsEnabled = false;
                    point.IsEnabled = false;


                    plus.IsEnabled = false;
                    minus.IsEnabled = false;
                    multiplication.IsEnabled = false;
                    division.IsEnabled = false;

                    cos.IsEnabled = false;
                    sin.IsEnabled = false;
                    tg.IsEnabled = false;
                    ctg.IsEnabled = false;
                    percent.IsEnabled = false;
                    stepin.IsEnabled = false;
                    log.IsEnabled = false;
                    Factorial.IsEnabled = false;
                    Sqrt.IsEnabled = false;
                    znak.IsEnabled = true;

                    input.Clear();
                    label.Content = a.ToString() + "+";
                }
              
            }
            catch(Exception d)
            {
             
            }


        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {
                    a = decimal.Parse(input.Text);
                }
                if (input.Text != "")
                {
                    count = "-";
                minus.IsEnabled = false;
                point.IsEnabled = false;

                input.Clear();
                plus.IsEnabled = false;
                minus.IsEnabled = false;
                multiplication.IsEnabled = false;
                division.IsEnabled = false;

                cos.IsEnabled = false;
                sin.IsEnabled = false;
                tg.IsEnabled = false;
                ctg.IsEnabled = false;
                percent.IsEnabled = false;
                stepin.IsEnabled = false;
                log.IsEnabled = false;
                Factorial.IsEnabled = false;
                Sqrt.IsEnabled = false;
                    znak.IsEnabled = true;


                label.Content = a.ToString() + "-";
                 }
            }
            catch (Exception d)
            {
                
            }

        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {

                    a = decimal.Parse(input.Text);
                }
                if (input.Text != "")
                {
                    count = "*";
                minus.IsEnabled = false;
                point.IsEnabled = false;

                input.Clear();
                plus.IsEnabled = false;
                minus.IsEnabled = false;
                multiplication.IsEnabled = false;
                division.IsEnabled = false;

                cos.IsEnabled = false;
                sin.IsEnabled = false;
                tg.IsEnabled = false;
                ctg.IsEnabled = false;
                percent.IsEnabled = false;
                stepin.IsEnabled = false;
                log.IsEnabled = false;
                Factorial.IsEnabled = false;
                Sqrt.IsEnabled = false;



                label.Content = a.ToString() + "*";
                 }
            }
            catch (Exception d)
            {
               
            }
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {

                    a = decimal.Parse(input.Text);
                }
                if (input.Text != "")
                {
                    count = "/";
                minus.IsEnabled = false;
                point.IsEnabled = false;

                input.Clear();
                plus.IsEnabled = false;
                minus.IsEnabled = false;
                multiplication.IsEnabled = false;
                division.IsEnabled = false;

                cos.IsEnabled = false;
                sin.IsEnabled = false;
                tg.IsEnabled = false;
                ctg.IsEnabled = false;
                percent.IsEnabled = false;
                stepin.IsEnabled = false;
                log.IsEnabled = false;
                Factorial.IsEnabled = false;
                Sqrt.IsEnabled = false;



                label.Content = a.ToString() + "/";
                 }
            }
            catch (Exception d)
            {
                
            }
        }
        public void Calc()
        {
            try
            {



                switch (count)
                {
                    case "+":

                        {
                            b = a + decimal.Parse(input.Text);

                            input.Text = b.ToString();
                            
                        }
                        break;
                    case "-":
                        {
                            b = a - decimal.Parse(input.Text);
                            input.Text = b.ToString();

                        }
                        break;
                    case "*":
                        {
                            b = a * decimal.Parse(input.Text);
                            input.Text = b.ToString();

                        }
                        break;
                    case "/":
                        {
                           
                            b = a / decimal.Parse(input.Text);
                         
                           input.Clear();
                         input.Text = b.ToString();

                        }
                        break;
                    case "^":
                        {
                            input.Text = (Math.Pow(double.Parse(a.ToString()), double.Parse(num2.ToString()))).ToString();
                        }
                        break;
                    case "%":
                        {
                            decimal k;
                            k =Convert.ToDecimal(num2);
                            input.Text = (a % k).ToString();
                        }
                        break;
                    default:
                    
                        break;
                }
            }
            catch (Exception e)
            {
               
            }

        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {
                    num2 = double.Parse(input.Text);
                }
                if (input.Text != "")
                {
                    Calc();
                    plus.IsEnabled = true;
                    minus.IsEnabled = true;
                    division.IsEnabled = true;
                    multiplication.IsEnabled = true;
                    //point.IsEnabled = true;

                    cos.IsEnabled = true;
                    sin.IsEnabled = true;
                    tg.IsEnabled = true;
                    ctg.IsEnabled = true;
                    percent.IsEnabled = true;
                    stepin.IsEnabled = true;
                    log.IsEnabled = true;
                    Factorial.IsEnabled = true;
                    Sqrt.IsEnabled = true;


                    label.Content = "";
                }
            }catch(Exception d)
            {
              
            }
        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            try { 
            
            minus.IsEnabled = true;
            point.IsEnabled = true;
            plus.IsEnabled = true;
          
            multiplication.IsEnabled = true;
            division.IsEnabled = true;
            cos.IsEnabled = true;
            sin.IsEnabled = true;
            tg.IsEnabled = true;
            ctg.IsEnabled = true;
            percent.IsEnabled = true;
            stepin.IsEnabled = true;
            log.IsEnabled = true;
            Factorial.IsEnabled = true;
            Sqrt.IsEnabled = true;
            znak.IsEnabled = true;

            a = 0;
            b = 0;
            num2 = 0;

            input.Clear();
            
            label.Content = "";
            }catch(Exception d)
            {
                MessageBox.Show(d.ToString());
            }
        }
        public void FuncPoint()
        {
            try
            {

            
            //string s =",";
            char bl = ',';
            string s;
            s = input.Text;
            double b;
            int index=0;
            int count = 0;
            b =Convert.ToDouble(input.Text);
           
           
                if (count == 0)
                {
                    index = s.IndexOf(bl);
                    count++;
                     point.IsEnabled = true;
                   
                    
                    if(count ==1)
                    {
                      
                        input.Text.TrimEnd();
                        point.IsEnabled = false;
                    }
                    
                    if (input.Text.Length != ',')
                    {

                    }
                    else

                    point.IsEnabled = true;

                }
                else
                {
                    
                    // point.IsEnabled = true;
                  
                }
            } catch(Exception d)
            {
              
            }
            }


        private void Point_Click(object sender, RoutedEventArgs e)
        {
            
            FuncPoint();
          if(input.Text.Length==','&&input.Text.Length=='-')
            {
               
            }
          else
            {

                input.Text += ",";
                znak.IsEnabled = false;

            }
           
        }

        private void Input_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            try { 
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
            }
            catch(Exception d)
            {
                MessageBox.Show(d.ToString());
            }
        }

        private void Stepin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {
                    a = decimal.Parse(input.Text);
                }
                if (input.Text != "")
                {
                    count = "^";
                    minus.IsEnabled = false;
                    point.IsEnabled = false;

                    input.Clear();
                    plus.IsEnabled = false;
                    minus.IsEnabled = false;
                    multiplication.IsEnabled = false;
                    division.IsEnabled = false;

                    cos.IsEnabled = false;
                    sin.IsEnabled = false;
                    tg.IsEnabled = false;
                    ctg.IsEnabled = false;
                    percent.IsEnabled = false;
                    stepin.IsEnabled = false;
                    log.IsEnabled = false;
                    Factorial.IsEnabled = false;
                    Sqrt.IsEnabled = false;

                    label.Content = a.ToString() + "^";
                }
            }
            catch (Exception d)
            {
                
            }
        }

        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {

                    a = decimal.Parse(input.Text);
                }
                if (input.Text != "")
                {
                    count = "%";
                minus.IsEnabled = false;
                point.IsEnabled = false;

                input.Clear();
                plus.IsEnabled = false;
                minus.IsEnabled = false;
                multiplication.IsEnabled = false;
                division.IsEnabled = false;

                cos.IsEnabled = false;
                sin.IsEnabled = false;
                tg.IsEnabled = false;
                ctg.IsEnabled = false;
                percent.IsEnabled = false;
                stepin.IsEnabled = false;
                log.IsEnabled = false;
                Factorial.IsEnabled = false;
                Sqrt.IsEnabled = false;
                


                label.Content = a.ToString() + "%";
                }
            }
            catch (Exception d)
            {
                
            }
        }
        double num1=0;
       public double q = (180.0 / Math.PI);
        private void Cos_Click(object sender, RoutedEventArgs e)
        {
           
          
         
            try
            {
                znak.IsEnabled = false; ////
                 point.IsEnabled = false;
                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {

                    label.Content = "Deg";
                    num1 = double.Parse(input.Text);
                    num1 /= q;
                }
                if (input.Text != "")
                {
                    if (count == "")
                    {  
                       
                        input.Text = (Math.Cos((double.Parse(input.Text)))).ToString();
                    }
                    else
                     if (num1 != 0 && count != "" && num2 == 0)

                        input.Text = (Math.Cos(double.Parse(num1.ToString()))).ToString();
                         

                    else

                    {

                        num2 = double.Parse(input.Text);


                        switch (count)

                        {

                            case "+":

                                input.Text = (num1 + num2).ToString();

                                break;

                            case "-":

                                input.Text = (num1 - num2).ToString();

                                break;

                            case "×":

                                input.Text = (num1 * num2).ToString();

                                break;

                            case "÷":

                                input.Text = (num1 / num2).ToString();

                                break;

                            case "^":

                                input.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();

                                break;

                            case "%":

                                input.Text = (num1 % num2).ToString();

                                break;

                        }

                        input.Text = (Math.Cos(double.Parse(input.Text))).ToString();

                    }
                }
            }catch(Exception d)
            {
                
            }
        }

        private void Sin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                znak.IsEnabled = false;
                point.IsEnabled = false;
                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {

                    label.Content = "Radian";
                    num1 = double.Parse(input.Text);
                    num1 /= q;
                }
                if (input.Text != "")
                {
                    if (count == "")

                        input.Text = (Math.Sin(double.Parse(input.Text))).ToString();

                    else if (num1 != 0 && count != "" && num2 == 0)

                        input.Text = (Math.Sin(double.Parse(num1.ToString()))).ToString();

                    else

                    {

                        num2 = double.Parse(input.Text);

                        switch (count)

                        {

                            case "+":

                                input.Text = (num1 + num2).ToString();

                                break;

                            case "-":

                                input.Text = (num1 - num2).ToString();

                                break;

                            case "×":

                                input.Text = (num1 * num2).ToString();

                                break;

                            case "÷":

                                input.Text = (num1 / num2).ToString();

                                break;

                            case "^":

                                input.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();

                                break;

                            case "%":

                                input.Text = (num1 % num2).ToString();

                                break;

                        }

                        input.Text = (Math.Sin(double.Parse(input.Text))).ToString();

                    }
                }
            }catch(Exception d)
            {
               
            }
    }

        private void Tg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                znak.IsEnabled = false;
                point.IsEnabled = false;
                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {
                    

                    label.Content = "Deg";
                    num1 = double.Parse(input.Text);
                    if( num1 % 360 == 90 || num1 % 360 == 270)
                    {
                       MessageBox.Show("Tg 90 does not exist");
                        input.Clear();
                    }
                    else { num1 /= q;
                }
                if (input.Text != "")
                {
                    if (count == "")
                        if (num1%360==90|| num1 % 360 == 270)
                        {
                                
                            MessageBox.Show("gg");
                            
                        }else
                    input.Text = (Math.Tan(double.Parse(input.Text))).ToString();

                    else if (num1 != 0 && count != "" && num2 == 0)
                        if (num1 == 90 && num1 == 270)
                        {
                                MessageBox.Show("Tg 90 does not exist");
                                input.Clear();
                            }
                        else

                            input.Text = (Math.Tan(double.Parse(num1.ToString()))).ToString();

                    else

                    {

                        num2 = double.Parse(input.Text);



                        switch (count)

                        {

                            case "+":

                                input.Text = (num1 + num2).ToString();

                                break;

                            case "-":

                                input.Text = (num1 - num2).ToString();

                                break;

                            case "×":

                                input.Text = (num1 * num2).ToString();

                                break;

                            case "÷":

                                input.Text = (num1 / num2).ToString();

                                break;

                            case "^":

                                input.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();

                                break;

                            case "%":

                                input.Text = (num1 % num2).ToString();

                                break;

                        }


                        if (num1 == 90 || num1 == 270)
                        {
                            MessageBox.Show("Tg 90 does not exist");
                                input.Clear();
                            }
                        else
                            input.Text = (Math.Tan(double.Parse(input.Text))).ToString();
                    }
                    }
                }
            }catch(Exception d)
            {
                MessageBox.Show(d.ToString());
            }
        }
        public static double Cotan(double x)
        {
            return 1.0 / Math.Tan(x);
        }
        private void Ctg_Click(object sender, RoutedEventArgs e)
        {
            double num3 = 0;
            try
            {
                znak.IsEnabled = false;
                point.IsEnabled = false;
                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {

                    
                    label.Content = "Deg";
                }
                if (input.Text != "")
                {
                    double res;

                    num3 = double.Parse(input.Text);
                    if (num1 % 360 == 90 || num1 % 360 == 270)
                    {
                        MessageBox.Show("cTg 0 or 180 or do not exist");
                        input.Clear();
                    }
                    else
                    {
                        num3 /= q;
                        if (count == "")
                        {
                            res = Cotan(num3);
                            input.Text = Convert.ToString(res);
                        }
                        else if (num1 != 0 && count != "" && num2 == 0)
                        {
                            res = Cotan(num3);
                            input.Text = Convert.ToString(res);
                        }
                        else

                        {

                            num2 = double.Parse(input.Text);



                            switch (count)

                            {

                                case "+":

                                    input.Text = (num1 + num2).ToString();

                                    break;

                                case "-":

                                    input.Text = (num1 - num2).ToString();

                                    break;

                                case "×":

                                    input.Text = (num1 * num2).ToString();

                                    break;

                                case "÷":

                                    input.Text = (num1 / num2).ToString();

                                    break;

                                case "^":

                                    input.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();

                                    break;

                                case "%":

                                    input.Text = (num1 % num2).ToString();

                                    break;

                            }



                            res = Cotan(num3);
                            input.Text = Convert.ToString(res);

                        }
                    }
                }
            }catch(Exception d)
            {
                MessageBox.Show(d.ToString());
            }
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                znak.IsEnabled = false;
                point.IsEnabled = false;
                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {


                    num1 = double.Parse(input.Text);
                }
                if (input.Text != "")
                {
                  

                    if (count == "")

                        input.Text = (Math.Log(double.Parse(input.Text))).ToString();

                    else if (num1 != 0 && count != "" && num2 == 0)

                        input.Text = (Math.Log(double.Parse(num1.ToString()))).ToString();

                    else

                    {

                        num2 = double.Parse(input.Text);



                        switch (count)

                        {

                            case "+":

                                input.Text = (num1 + num2).ToString();

                                break;

                            case "-":

                                input.Text = (num1 - num2).ToString();

                                break;

                            case "×":

                                input.Text = (num1 * num2).ToString();

                                break;

                            case "÷":

                                input.Text = (num1 / num2).ToString();

                                break;

                            case "^":

                                input.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();

                                break;

                            case "%":

                                input.Text = (num1 % num2).ToString();

                                break;

                        }



                        input.Text = (Math.Log(double.Parse(input.Text))).ToString();

                    }
                }
            }catch(Exception d)
            {
                
            }
        }

        private void Factorial_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {

                }
                if (input.Text != "")
                {
                    long f = 1;

                    for (long i = 1; i <= long.Parse(input.Text); i++)

                    {

                        f *= i;

                    }

                    input.Text = f.ToString();
                }
        } catch(Exception d)
            {
                MessageBox.Show("Please enter the correct numbers");
            }
             }

        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (input.Text == "")
                {
                    MessageBox.Show("Enter data");

                }
                else
                {



                    num1 = double.Parse(input.Text);
                }
                if (input.Text != "")
                {
                    if (count == "")

                        input.Text = (Math.Sqrt(double.Parse(input.Text))).ToString();

                    else if (num1 != 0 && count != "" && num2 == 0)

                        input.Text = (Math.Sqrt(double.Parse(num1.ToString()))).ToString();

                    else

                    {

                        num2 = double.Parse(input.Text);



                        switch (count)

                        {

                            case "+":

                                input.Text = (num1 + num2).ToString();

                                break;

                            case "-":

                                input.Text = (num1 - num2).ToString();

                                break;

                            case "×":

                                input.Text = (num1 * num2).ToString();

                                break;

                            case "÷":

                                input.Text = (num1 / num2).ToString();

                                break;

                            case "^":

                                input.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();

                                break;

                            case "%":

                                input.Text = (num1 % num2).ToString();

                                break;

                        }



                        input.Text = (Math.Sqrt(double.Parse(input.Text))).ToString();

                    }
                }
        }catch(Exception d)
            {
                MessageBox.Show(d.ToString());
            }
    }

        private void Crash_Click(object sender, RoutedEventArgs e)
        {
            DialogResult resultt = MessageBox.Show(
                   "You try to crash my programe ?",
                  "Good game, wp",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (resultt == System.Windows.Forms.DialogResult.Yes)
            {
                while (true)
                {
                    MessageBox.Show("Nice try xD");

                }
            }
            else
            {
                MessageBox.Show("Good choice <3");
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if (input.Text != "0")
            {
                if (input.Text.Length == 1)
                {
                    input.Text = "";
                }
                else if (input.Text.Length > 0)
                {
                    input.Text = input.Text.Substring(0, input.Text.Length - 1);
                        a = 0;
                        b = 0;
                        num2=0;
                }
            }
            }catch(Exception d)
            {
                MessageBox.Show(d.ToString());
            }
            
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
            string s = input.Text;
            if (String.IsNullOrEmpty(s))
            {
                point.IsEnabled = false;
            }
            else
            {
                point.IsEnabled = true;
            }
        }

        private void Znak_Click(object sender, RoutedEventArgs e)
        {
            Factorial.IsEnabled = false;
            log.IsEnabled = false;
            Sqrt.IsEnabled = false;
            try
            {
                if (input.Text.Length == '.')
                {
                   
                }
                else znak.IsEnabled = false;

                if (znakk == true)
            {
                input.Text += "-";
                znakk = false;
                    if (input.Text.Length == '-')
                    {
                       
                    }
                    else znak.IsEnabled = false;
                   
           
                }
            else 
            {
                if (znakk == false)
                {
                       
                    input.Text = input.Text.Replace("-","");
                znakk = true;
                }

            }
            }catch(Exception d)
            {
                MessageBox.Show(d.ToString());
            }
        }
    }
}
