using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Otobüs_Bİleti_Alim_Satim_Otomasyonu
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Biletiptal : Window
    {
        public Biletiptal()
        {
            this.InitializeComponent();
        }

        private async void btnip_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog diolog = new ContentDialog();
            Title = "Silmek İstediğinizden Emin Misiniz?";
            diolog.PrimaryButtonText = "Evet";
            diolog.PrimaryButtonText = "Hayır";
            diolog.CloseButtonText = "İptal";
            diolog.DefaultButton = ContentDialogButton.Primary;

            await diolog.ShowAsync();

        }


    }
}
