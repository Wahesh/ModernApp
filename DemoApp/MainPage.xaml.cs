using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using DemoApp.DataReference;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// 
    /// 
    /// 
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            call();

            
        }

        public async void  call(){
        
         try
            {

                 DataModelSoapClient proxy = new DataModelSoapClient();
                var result = await proxy.GetNewsAsync();

                show s = new show();

              lblNewsHeadLine.Text = result.Body.GetNewsResult.NewsHead.ToString();
              //= result[4].Photo.ToString();
              
             
            lblNewsDetails.Text = result.Body.GetNewsResult.NewsDetail.ToString();
           //     s.Adv2 = result[4].Adv1.ToString();
           //     s.NewsDescription = result[4].NewsDescription.ToString();


              
            
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
            }
        
        }

      
        }


      
    }
