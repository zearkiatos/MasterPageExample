using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterPageExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LayoutPage : ContentPage
	{
        private View mainContent;

        public View MainContent
        {
            get { return mainContent; }
            set {
                if(mainContent != value)
                {
                    mainContent = value;
                    MainContentContainer.Children.Add(mainContent);
                    OnPropertyChanged("MainContent");
                }

            }
        }

        public LayoutPage ()
		{
			InitializeComponent ();
		}

        
	}
}