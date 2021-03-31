using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: ExportFont("nunito-bold.ttf", Alias = "Nunito")]

namespace Chart_GettingStarted
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
	}

    public class ViewModel
    {
        public List<Person> Data { get; set; }
        public ViewModel()
        {
            Data = new List<Person>()
            {
                new Person("Jan", 180),
                new Person("Feb", 170),
                new Person("Mar", 160),
                new Person("Apr", 182)
            };
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public double Height { get; set; }

        public Person(string name, double height)
        {
            this.Name = name;
            this.Height = height;
        }
    }
}
