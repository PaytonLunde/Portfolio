using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Input.Inking;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;
using Windows.System.Display;
using Windows.Media.Playback;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Examples
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DisplayRequest appDisplyRequest = null;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_click(object sender, RoutedEventArgs e)
        {
            await SetLocalMedia();
        }
        async private System.Threading.Tasks.Task SetLocalMedia()
        {
            var openPicker = new Windows.Storage.Pickers.FileOpenPicker();
            openPicker.FileTypeFilter.Add(".wmv");
            openPicker.FileTypeFilter.Add(".mp4");
            openPicker.FileTypeFilter.Add(".wma");
            openPicker.FileTypeFilter.Add(".mp3");
            openPicker.FileTypeFilter.Add(".wav");
            var file = await openPicker.PickSingleFileAsync();
            // mediaPlayer is a MediaPlayerElement defined in XAML
            if (file != null)
            {
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                mediaSimple.SetSource(stream, file.ContentType);
                mediaSimple.Play();
            }
        }

        private void MediaSimple_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            MediaPlaybackSession playbackSession = sender as MediaPlaybackSession;
            if (playbackSession != null && playbackSession.NaturalVideoHeight != 0)
            {
                if (playbackSession.PlaybackState == MediaPlaybackState.Playing)
                {
                    if (appDisplyRequest == null)
                    {
                        appDisplyRequest = new DisplayRequest();
                        appDisplyRequest.RequestActive();
                    }
                }
                else
                {
                    if (appDisplyRequest != null)
                    {
                        appDisplyRequest.RequestRelease();
                        appDisplyRequest = null;
                    }
                }
            }
        }
        private void PictureSize_click(object sender, RoutedEventArgs e)
        {
            switch (mediaSimple.Stretch)
            {
                case Stretch.Fill:
                    mediaSimple.Stretch = Stretch.None;
                    break;
                case Stretch.None:
                    mediaSimple.Stretch = Stretch.Uniform;
                    break;
                case Stretch.Uniform:
                    mediaSimple.Stretch = Stretch.UniformToFill;
                    break;
                case Stretch.UniformToFill:
                    mediaSimple.Stretch = Stretch.Fill;
                    break;
                default:
                    break;
            }
        }

        private void FullWindow_Clcik(object sender, RoutedEventArgs e)
        {
            mediaSimple.IsFullWindow = !mediaSimple.IsFullWindow;
        }
    }
}
