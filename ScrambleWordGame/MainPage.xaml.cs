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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ScrambleWordGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            FindWord();
        }

        void FindWord()
        {
            string searchWord = "tars";
            List<string> foundWords = new List<string>(); // star, rats, arts;
            string words = System.IO.File.ReadAllText("wordsEn.txt");
            List<string> wordsList = words.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None).ToList<string>();
            /*
            1) Remove words from wordsList where words length > 4
            2) Search in wordsList which has combination of searchWord (tars)
                Call function by SearchWord(List<string> wordsListFilteredByLength, string searchWord)
            */
            return;
        }

        List<string> SearchWord(List<string> wordsListFilteredByLength, string searchWord)
        {
            List<string> wordsFound = new List<string>();
            /*
            1) Split the searchWord into Char array or list
            2) Search each character in the wordsListFilteredByLenght
            */
            return wordsFound;
        }

    }
}
