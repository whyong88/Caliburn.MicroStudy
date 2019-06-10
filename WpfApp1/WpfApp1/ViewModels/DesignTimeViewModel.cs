using Caliburn.Micro;

namespace WpfApp1.ViewModels
{
    public class DesignTimeViewModel:Screen
    {
        public string Text => Execute.InDesignMode ? "Design Time" : "Run Time";
    }
}