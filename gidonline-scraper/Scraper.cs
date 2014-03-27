using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace lostfilm.tv_app_win8.DataScraping
{
    class Scraper
    {

        public async static Task scrap(string html)
        {
                return;
        }

        public static string GetHtmlString(string leftBorder, string rightBorder, string html, int location)  //return substring, which is between "leftBorder" and "rightBorder"
        {
            string subString;
            int begin = html.IndexOf(leftBorder, location) + leftBorder.Length;
            int end = html.IndexOf(rightBorder, begin);
            subString = html.Substring(begin, end - begin);
            return subString;
        }

        public static List<int> GetElementIndex(string html, string key)            //return all indexes of "key" in html
        {
            int temp;
            int currentIndex = 1;
            List<int> index = new List<int>();

            while (true)
            {
                temp = html.IndexOf(key, currentIndex);
                if (temp > 0)
                {
                    index.Add(temp);
                    currentIndex = index.Last();
                    currentIndex++;
                }
                else
                    break;
            }             
            return index;
        }

        public async static Task<Movie> GetMovieInfo(string html, int EpisodLocation)
        {
           
            return currentMovie;
        }

        public static void EpisodFormat(Movie currentMovie)
        {
            currentMovie.movieTitle = clearFromHtml(currentMovie.movieTitle);
        }


        public static string clearFromHtml(string data)
        {
            int openTagIndex = 0;
            int closeTagIndex = 0;

            while (true)
            {
                openTagIndex = data.IndexOf('<', closeTagIndex);
                if (openTagIndex == -1)
                    break;
                closeTagIndex = data.IndexOf('>', openTagIndex);
                data = data.Remove(openTagIndex, closeTagIndex - openTagIndex + 1);
                closeTagIndex = openTagIndex;
            }
            return data;
        }
    }
}
