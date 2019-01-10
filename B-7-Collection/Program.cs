using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListExample();
            //ArrayListExample2();

            List<Neighbor> floorNeighbors = new List<Neighbor>();

            floorNeighbors.Add( new Neighbor() {fullName = "Bill", flatNumber = 3, phoneNumber = 299379992 });
            floorNeighbors.Add(new Neighbor() { fullName = "Monika", flatNumber = 5, phoneNumber = 292220327 });
            floorNeighbors.Add(new Neighbor() { fullName = "Joy", flatNumber = 7, phoneNumber = 291111111 });

            Console.WriteLine("Enter room number");
            var roomNumber = Convert.ToInt32(Console.ReadLine());

            foreach ( Neighbor nbr in floorNeighbors)
            {
                if (roomNumber == nbr.flatNumber)
                {
                    Console.WriteLine($"Neighbor's Name {nbr.fullName} and phone {nbr.phoneNumber}");
                }


                
            }

            Console.ReadLine();
        }

        static void ArrayListExample2()
        {
            var list = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Next row plz");
                var song = new Song()
                {
                    Lyrics = Console.ReadLine()
                };

                list.Add(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            list.Sort();
            list.RemoveAt(list.Count - 1);

            foreach (var row in list)
            {
                Console.WriteLine(row);
            }
        }

        public static void ArrayListExample()
        {
            var poem = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                var song = new Song();
                song.Lyrics = Console.ReadLine();
                poem.Add(song);
            }

            //poem.Sort();
            poem.RemoveAt(poem.Count - 1);

            object[] myArray = poem.ToArray();

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

        }

        public class Song
        {
            public string Lyrics;

            public override string ToString()
            {
                return this.Lyrics;
            }
        }

        
    }
}
