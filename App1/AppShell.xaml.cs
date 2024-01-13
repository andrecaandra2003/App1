using App1.Views;

namespace App1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddUpdateClienti), typeof(AddUpdateClienti));

        }
    }
}
