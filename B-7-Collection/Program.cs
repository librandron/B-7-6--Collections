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


            //LIST

            //List<Neighbor> floorNeighbors = new List<Neighbor>();

            //floorNeighbors.Add( new Neighbor() {fullName = "Bill", flatNumber = 3, phoneNumber = 299379992 });
            //floorNeighbors.Add(new Neighbor() { fullName = "Monika", flatNumber = 5, phoneNumber = 292220327 });
            //floorNeighbors.Add(new Neighbor() { fullName = "Joy", flatNumber = 7, phoneNumber = 291111111 });

            //Console.WriteLine("Enter room number");
            //var roomNumber = Convert.ToInt32(Console.ReadLine());

            //foreach ( Neighbor nbr in floorNeighbors)
            //{
            //    if (roomNumber == nbr.flatNumber)
            //    {
            //        Console.WriteLine($"Neighbor's Name {nbr.fullName} and phone {nbr.phoneNumber}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You never find your neighbor");
            //    }

                
            //}

            //Console.ReadLine();



            //DICTIONARY

            Dictionary<int, Neighbor> floorNeighbors = new Dictionary<int, Neighbor>();

            floorNeighbors.Add(4, new Neighbor() { fullName = "Bill",  phoneNumber = 299379992 });
            floorNeighbors.Add(1, new Neighbor() { fullName = "Monika",  phoneNumber = 292220327 });
            floorNeighbors.Add(18, new Neighbor() { fullName = "Joy", phoneNumber = 291111111 });



            Console.WriteLine("Enter room number");
            var roomNumber = Convert.ToInt32(Console.ReadLine());

            foreach (int key in floorNeighbors.Keys)
            {
                if(roomNumber == key)
                {
                    Console.WriteLine($"name {floorNeighbors[key].fullName} phone {floorNeighbors[key].phoneNumber}");
                }
            }


            //Console.WriteLine(floorNeighbors[4].fullName);

            //foreach (KeyValuePair<int, Neighbor> keyValue in floorNeighbors)
            //{
            //    if (roomNumber == keyValue.Key)
            //    {
            //        Console.WriteLine($"Neighbor's Name {keyValue.Value.fullName} and phone {keyValue.Value.phoneNumber}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You never find your neighbor");
            //        break;
            //    }


            //}

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
