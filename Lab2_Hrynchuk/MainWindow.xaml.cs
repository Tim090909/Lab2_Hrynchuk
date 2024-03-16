using Lab2_Hrynchuk.Model;
using Lab2_Hrynchuk.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab2_Hrynchuk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
        }

        private void Proceed_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) &&
                !string.IsNullOrEmpty(txtLastName.Text) &&
                !string.IsNullOrEmpty(txtEmailAddress.Text) &&
                dpBirthDate.SelectedDate != null)
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string emailAddress = txtEmailAddress.Text;
                DateTime birthDate = dpBirthDate.SelectedDate.Value;

                Person person = new Person(firstName, lastName, emailAddress, birthDate);


                bool isValidAge = person.PersonAgeValidation(birthDate);

                if ( isValidAge) {
                    if (person.IsBirthday)
                    {
                        MessageBox.Show($"Happy Birthday!\n We wish you all the best!", "Happy Birthday!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    txtName.Text = $"You are {person.FirstName} {person.LastName}";
                    txtEmail.Text = $"Your Email: {person.EmailAddress}";
                    txtDob.Text = $"Your Birth Date: {person.BirthDate.ToShortDateString()}";
                    txtIsAdult.Text = "Is Adult - " + (person.IsAdult ? "Yes" : "No");
                    txtSunSign.Text = "By Sun Sing - " + (person.SunSign);
                    txtChineseSign.Text = "By Chinese Sign - " + (person.ChineseSign);
                    txtIsBirthday.Text = "Is Today Birthday - " + (person.IsBirthday ? "Yes" : "No");
                }
                return;
            }

            proceedButton.IsEnabled = false;
        }
    }
}