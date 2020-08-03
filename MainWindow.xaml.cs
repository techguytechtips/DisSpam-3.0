using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WPF_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public bool infPings = false;
        public bool stap;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            infPings = true;
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            infPings = false;
        }
        async private void SpamButton(object sender, RoutedEventArgs e)
        {
            stap = false;
            await Task.Delay(6000);
            if (infPings == true) {
                while (stap != true)
                {
                    if (this.DisText.Text == "")
                    {
                        System.Windows.MessageBox.Show("Please Enter Text to Spam", "Spam Error");
                        break;
                    }
                    SendKeys.SendWait(this.DisText.Text);
                    SendKeys.SendWait("{Enter}");
                    SendKeys.SendWait("{Enter}");
                    try
                    {
                        await Task.Delay(Convert.ToInt32(this.Delay.Text));
                    }
                    catch (System.FormatException)
                    {
                        System.Windows.MessageBox.Show("Please enter a delay.", "Delay Error");
                        break;
                    }
                }
            }else if (this.NOP.Text == "")
            {
                System.Windows.MessageBox.Show("Please enter a number of pings.", "NOP Error");
            }
            else
            {
                int i = 1;
                try
                {
                    while (stap != true && i <= Convert.ToInt32(this.NOP.Text))
                    {
                        if (this.DisText.Text == "")
                        {
                            System.Windows.MessageBox.Show("Please Enter Text to Spam.", "Spam Error");
                            break;
                        }
                        SendKeys.SendWait(this.DisText.Text);
                        SendKeys.SendWait("{Enter}");
                        SendKeys.SendWait("{Enter}");
                        i++;
                        try
                        {
                            await Task.Delay(Convert.ToInt32(this.Delay.Text));
                        }
                        catch (System.FormatException)
                        {
                            System.Windows.MessageBox.Show("Please enter a delay", "Delay Error");
                            break;
                        }
                    }
                }catch (System.FormatException)
                {
                    System.Windows.MessageBox.Show("Invaild input in Number of Pings", "NOP Error");
                }
                
            }

           

        }
        private void StopButton(object sender, RoutedEventArgs e)
        {
            stap = true;
        }
       
    }
}
