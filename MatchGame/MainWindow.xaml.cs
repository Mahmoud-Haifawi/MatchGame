using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    using System.Windows.Threading;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window//**
    {
        
        public MainWindow()
        {
            InitializeComponent();//**

            SetUpGame();
        }

       

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐙", "🐙",
                "🐡", "🐡",
                "🐘", "🐘",
                "🐳", "🐳",
                "🐪", "🐪",
                "🦕", "🦕",
                "🦘", "🦘",
                "🦔", "🦔",
                
                //عناصر الارري كانت 16 لانه عدد البلوكس هو 16, ولازم من كل ايموجي 2 متشابهات
            };

            Random random = new Random();// عرفت راندوم عشان اقدر اغير اماكن الايموجي بين كل رن و الثاني 

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBlock")
                {
                     textBlock.Visibility = Visibility.Visible;//**
                    int index = random.Next(animalEmoji.Count);// pick a random number between 0 and the number of emoji left in the list and called "index"
                    string nextEmoji = animalEmoji[index];//لانه قاعدين منعامل مع array  
                    textBlock.Text = nextEmoji;// update the TextBlock with the random emoji 
                   animalEmoji.RemoveAt(index);// عشان ما يتكررر الايموجي المتشابه اكثر من مرتين ف رح احذفه من الارري الاصلية  
                }
            }

            
        }

       /* TextBlock lastTextBlockClicked;
        bool findingMatch = false;*/

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}