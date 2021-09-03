using System.Collections.Generic;
using QuoteOfTheDay.Models;

namespace QuoteOfTheDay
{
    public static class DataStore
    {
        static List<Quote> quoteList = new List<Quote>
        {
                    new Quote { Text = "Scorpios are the most unconditional lovers you can be blessed with", Author = "King Alex" },
                    new Quote { Text = "Anyone after Scorpio, you’re merely settling. I promise", Author= "saga c" },
                    new Quote { Text = "Scorpio tends to be extreme in everything they do. They intensely love; They intensely hate.", Author = "Starr Mpama" },
                    new Quote {Text= "Choose me or lose me. I’m not a backup plan and definitely not a second choice.", Author = "Nene oprah" },
                    new Quote { Text = "I’m a Scorpio. I have different mood swings.", Author = "Craig Robinson" },
                    new Quote { Text = "I’m a Scorpio, and who knows if there is any validity to it, but I’m very emotional. I have high highs and low lows.", Author = " Chely Wright" },
                    new Quote { Text = "I used to be very revenge motivated, but that’s just because I’m a Scorpio.", Author = "SZA" },
                    new Quote { Text = "Scorpio will always appear to have a tough surface. However, they feel emotions more deeply than any of the zodiac signs", Author = "Unknown" },
                    new Quote { Text = "I’m a Scorpio with a Pisces moon. I am very critical of myself. I’m actually way less critical of others than I am of myself", Author = "SZA" },
                    new Quote { Text = "I’m a Scorpio, and Scorpios eat themselves out and burn themselves up like me", Author = "Vivien Leigh" },
                    new Quote { Text = "I think, when I’m on the court, I become with a killer instinct – I’m a real Scorpio", Author = "Ava Ivanovic" },
                    new Quote { Text = "I really am a full-blown Scorpio. Whenever I look things up about my sign, it’s like check, check check: thoughtful, detailed, moody, stubborn, prideful, emotional.", Author = " Selah Louise Marley" },
                    new Quote { Text = "A Scorpio will probe until they reach the truth. They will ask you the same question over and over to catch you slipping in your story", Author = "Unknown" },
                    new Quote { Text = "A Scorpio is easy to please, but hard to handle", Author = "King Alex" },
                    new Quote { Text = "When everyone has stopped believing in you, a Scorpio will be there. One thing you never have to worry about is them being disloyal.", Author = "Unknown" },
                    new Quote { Text = "Scorpios are some of the realest and nicest people ever. You’ll only see their dark side come out when they’ve been pushed too far", Author = "Queen Esther" },
                    new Quote { Text = "A Scorpio will give you several chances but once they turn their back, they never look back", Author = "Starr Mpama" },
                    new Quote { Text = "If you have a hidden agenda, trust that a Scorpio will find out. This is one sign that sits back and observes things.", Author = "Dumy" },
                    new Quote { Text = "Before you can even finish talking, a Scorpio will already have you figured out.", Author = "Marian Makas" },
                    new Quote { Text = "Anna Wintour is a very smart woman. She’s a Scorpio, like me.", Author = "RuPaul" },
                    new Quote { Text = "Talk to yourself like you would to someone you love.", Author = "Brené Brown" },
                    new Quote { Text = "For small creatures such as we the vastness is bearable only through love.", Author = "Carl Sagan" },
                    new Quote { Text = "I’ve been absolutely terrified every moment of my life – and I’ve never let it keep me from doing a single thing I wanted to do.", Author = "Georgia O’Keeffe" },
                    new Quote { Text = "As we look ahead into the next century, leaders will be those who empower others.", Author = "Bill Gates" },
                    new Quote { Text = "The only thing that will make you happy is being happy with who you are, and not who people think you are.", Author = "Goldie Hawn" },
                    new Quote { Text = "Nothing in life is to be feared. It is only to be understood.", Author = " Marie Curie" },
                    new Quote { Text = "“We cannot become what we need to be by remaining what we are", Author = "Max de Pree" },
                    new Quote { Text = "It takes strength to show vulnerability.", Author = "Dani ngozika" },
                    new Quote { Text = "Do what you can, with what you have, where you are.", Author = "Theodore Roosevelt" },
                    new Quote { Text = "Live out of your imagination. Not your history.", Author = " Stephen Covey" },
        };

        public static IEnumerable<Quote> GetAll => quoteList;
        public static List<Quote> getQuotes()
        {
            return quoteList;                
        }
        public static void addQuote(Quote quote)
        {
            
            quoteList.Add(quote);
        }
    }


}





