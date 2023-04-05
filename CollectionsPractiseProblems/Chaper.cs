using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractiseProblems
{
    internal class Chaper
    {
        public static void Page()
        {
            Console.Write("Enter the number of chapters: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // define chapter start and end pages
            List<int[]> chapters = new List<int[]>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the start and end pages of chapter {i + 1}: ");
                string[] input = Console.ReadLine().Split();
                int[] pages = { Convert.ToInt32(input[0]), Convert.ToInt32(input[1]) };
                chapters.Add(pages);
            }
            Console.Write("Enter the current reading page: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int chapterCount = 0;
            foreach (int[] chapter in chapters)
            {
                // check if the current page is within the chapter's range
                if (k >= chapter[0] && k <= chapter[1])
                {
                    chapterCount = n - chapters.IndexOf(chapter);
                    break;
                }
            }
            Console.WriteLine($"Chapters yet to read: {chapterCount}");
        }
    }
}


