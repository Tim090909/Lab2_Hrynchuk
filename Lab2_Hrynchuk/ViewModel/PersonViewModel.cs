using Lab2_Hrynchuk.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace Lab2_Hrynchuk.ViewModel
{
    internal class PersonViewModel
    {
        /*
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


                txtName.Text = $"You are {person.FirstName} {person.LastName}";
                txtEmail.Text = $"Your Email: {person.EmailAddress}";
                txtDob.Text = $"Your Birth Date: {person.BirthDate.ToShortDateString()}";
                txtIsAdult.Text = "Is Adult - " + (person.IsAdult ? "Yes" : "No");
                txtSunSign.Text = "By Sun Sing - " + (person.SunSign);
                txtChineseSign.Text = "By Chinese Sign - " + (person.ChineseSign);
                txtIsBirthday.Text = "Is Today Birthday - " + (person.IsBirthday ? "Yes" : "No");

                return;
            }

            proceedButton.IsEnabled = false;
        }*/
    }
}
