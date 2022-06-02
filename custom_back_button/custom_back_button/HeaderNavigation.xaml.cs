// https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/images?tabs=macos

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace custom_back_button
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeaderNavigation : StackLayout
    {
        public HeaderNavigation()
        {
            InitializeComponent();
        }
    }
}