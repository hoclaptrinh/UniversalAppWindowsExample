using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UniversalAppWindowsExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            SetupAccelerometer();
        }
       
        private void SetupAccelerometer()
        {
            var accelerometer = Windows.Devices.Sensors.Accelerometer.GetDefault();
            accelerometer.ReportInterval = 1000;
            if (accelerometer != null)
            {
                accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
            }
        }

        private void Accelerometer_ReadingChanged(Accelerometer sender, AccelerometerReadingChangedEventArgs args)
        {
            string text = String.Format("Accelerometer Reading:\t{0}\t (x:{1};y:{2};z:{3})", args.Reading.Timestamp.ToString(), 
                args.Reading.AccelerationX.ToString(),
                args.Reading.AccelerationY.ToString(),
                args.Reading.AccelerationZ.ToString());
            Debug.WriteLine(text);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "zzzzzzzzzzzzzzz";
        }

        private void button_Loading(FrameworkElement sender, object args)
        {

        }

        private void Grid_Loading(FrameworkElement sender, object args)
        {

        }
    }
}
