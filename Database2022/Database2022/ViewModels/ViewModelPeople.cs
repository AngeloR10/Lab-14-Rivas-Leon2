using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Database2022.ViewModels
{
    public class ViewModelPeople : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { SetValue(ref color, value); }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { SetValue(ref firstName, value); }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { SetValue(ref lastName, value); }
        }

        private string filter;
        public string Filter
        {
            get { return filter; }
            set { SetValue(ref filter, value); }
        }

        private List<Person> people;
        public List<Person> People
        {
            get { return people; }
            set { SetValue(ref people, value); }
        }

        // Nuevas propiedades
        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { SetValue(ref fecha, value); }
        }

        private string curso;
        public string Curso
        {
            get { return curso; }
            set { SetValue(ref curso, value); }
        }

        private string genero;
        public string Genero
        {
            get { return genero; }
            set { SetValue(ref genero, value); }
        }

        public ICommand SearchCommand { get; private set; }
        public ICommand InsertCommand { get; private set; }

        public ViewModelPeople()
        {
            SearchCommand = new Command(() =>
            {
                PersonService service = new PersonService();
                People = service.GetByText(Filter);
            });

            InsertCommand = new Command(() =>
            {
                PersonService service = new PersonService();
                int newPersonId = service.Get().Count + 1;
                service.Create(new Person
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    PersonId = newPersonId,
                    Fecha = Fecha,
                    Curso = Curso,
                    Genero = Genero
                });

                App.Current.MainPage.DisplayAlert("Success", "Your data are saved", "Ok");
            });
        }
    }
}
