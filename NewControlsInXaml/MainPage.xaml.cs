using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace NewControlsInXaml
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
        //    RenderTargetBitmap bitmap = new RenderTargetBitmap();
        //    await bitmap.RenderAsync(this);
            
            
        //    var pixelBuffer = (await bitmap.GetPixelsAsync()).ToArray();

        //                StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
        //    StorageFile newFile = await localFolder.CreateFileAsync(FileName.Text, CreationCollisionOption.GenerateUniqueName);


        //    using (Stream writeStream = await newFile.OpenStreamForWriteAsync())
        //    {
                
        //        writeStream.Size = (ulong)pixelBuffer.Length;
        //        BitmapEncoder encoder = await BitmapEncoder.CreateAsync(BitmapEncoder.PngEncoderId, writeStream);
        //        encoder.SetPixelData(BitmapPixelFormat.Rgba8, BitmapAlphaMode.Ignore, (uint)bitmap.PixelHeight, (uint)bitmap.PixelWidth, (double)72, (double)72, pixelBuffer);
                
        //        await writeStream.FlushAsync();
        //    }
        }
    }
}
