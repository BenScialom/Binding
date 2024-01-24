using Binding.Models;

namespace Binding
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public Student s { get; set; }
        public MainPage()
        {
            s = new Student() { Name = "Itamar", Age = 16 };
            this.BindingContext = s;
            InitializeComponent();
        }

        private void ChangeName(object sender, EventArgs e)
        {
            s.Name = "Ben";
        }
    }
}