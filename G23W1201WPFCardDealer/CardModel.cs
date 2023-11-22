using System.Linq;
using System;

namespace G23W1201WPFCardDealer;

class CardModel
{
    private int[] _cards = new int[5] {-1, -1, -1, -1, -1};
    
    
    public int[] Cards
    {
        //get { return _cards; }
        get => _cards;
    }

    public void Shuffle()
    {
        Random random = new Random();
        int[] num = new int[5] { -1, -1, -1, -1, -1 };

        for (int i = 0; i < num.Length; i++)
        {
            int n = 0;
            do
            {
                n = random.Next(46);
            } while (num.Contains(n));
            num[i] = n;
        }

        Array.Sort(num);

        _cards = num;
    }

}
