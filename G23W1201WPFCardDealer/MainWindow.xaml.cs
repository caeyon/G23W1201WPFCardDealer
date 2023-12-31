﻿using System;
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

namespace G23W1201WPFCardDealer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CardViewModel vm = new CardViewModel();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = vm;
        }

        private void OnDeal(object sender, RoutedEventArgs e)
        {

            vm.Shuffle();

            //Random random = new Random();
            //int[] num = new int[5] { -1, -1, -1, -1, -1 };

            //for (int i = 0; i < num.Length; i++)
            //{
            //    int n = 0;
            //    do
            //    {
            //        n = random.Next(46);
            //    } while (num.Contains(n));
            //    num[i] = n;
            //}

            //Array.Sort(num);

            //string[] resource = new string[num.Length];
            //BitmapImage[] b = new BitmapImage[num.Length];

            //for (int i = 0; i < num.Length; i++)
            //{
            //    resource[i] = $"Images/{GetCardName(num[i])}";
            //    b[i] = new BitmapImage(
            //    new Uri(resource[i], UriKind.RelativeOrAbsolute));
            //}

            //Card1.Source = b[0];
            //Card2.Source = b[1];
            //Card3.Source = b[2];
            //Card4.Source = b[3];
            //Card5.Source = b[4];

        }

        //private string GetCardName(int c)
        //{
        //    string suit = "";
        //    switch (c / 13)
        //    {
        //        case 0: suit = "spades"; break;
        //        case 1: suit = "diamonds"; break;
        //        case 2: suit = "hearts"; break;
        //        case 3: suit = "clubs"; break;
        //    }

        //    string rank = "";
        //    switch (c % 13)
        //    {
        //        case 0: rank = "ace"; break;
        //        case int n when (n > 0 && n < 10):
        //            rank = (c % 13 + 1).ToString(); break;
        //        case 10: rank = "jack"; break;
        //        case 11: rank = "queen"; break;
        //        case 12: rank = "king"; break;
        //    }

        //    //--------------------------------------------
        //    // Jack, Queen, King일 때 suit 뒤에 2 붙이기
        //    //--------------------------------------------
        //    // 방법 0. Windows Forms 때처럼 rank switch 문에서 suit에 "2" 추가

        //    // 방법 1. Contains 사용
        //    //if (new int[] { 10, 11, 12 }.Contains(c % 13)) //10,11,12를 갖는 new int[] 배열

        //    // 방법 2. IndexOf(), FindIndex() 함수 사용해도 됨

        //    // 방법 3. Lambda Expression을 사용하여 c % 13 값이 10, 11, 12와 일치하는지 검사
        //    if (Array.Exists(new int[] { 10, 11, 12 }, x => x == c % 13)) //두 번째 인자(x => x == c % 13)를 참으로 만드는 게 배열에 있는가
        //        return string.Format("{0}_of_{1}2.png", rank, suit);
        //    else
        //        return string.Format("{0}_of_{1}.png", rank, suit);
        //}
    }
}