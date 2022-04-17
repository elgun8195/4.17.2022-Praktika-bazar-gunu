using _4._17._2022_praktika.mODELS;
using System;

namespace _4._17._2022_praktika
{
    class Program
    {
        static void Main(string[] args)
        {

            Hotel hotel = new Hotel("Goyezen");
            Room room = new Room("Otaq 1", 55, 4);
            Room room1 = new Room("Otaq 2", 45, 3);
            hotel.AddRoom(room);
            hotel.AddRoom(room1);
            hotel.MakeReservation(1);
            hotel.MakeReservation(2);
            foreach (var rooms in hotel.GetRooms())
            {
                Console.WriteLine(rooms.ShowInfo());
            }
            Console.WriteLine(hotel.GetRooms().Length);
            #region switch case
            //foreach (var item in hotel.GetRooms())
            //{
            //    Console.WriteLine(item.ShowInfo());
            //}
            //bool check = true;
            //do
            //{
            //    Console.WriteLine("1. Create a room");
            //    Console.WriteLine("2. Add room");
            //    Console.WriteLine("3. Make reserve");
            //    Console.WriteLine("4. Show All Rooms");
            //    Console.WriteLine("0. Exit");

            //    string choice = Convert.ToString(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("Room name:");
            //            string name = Convert.ToString(Console.ReadLine());
            //            Console.WriteLine("Room price:");
            //            double price= Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Room personcapacity?:");
            //            int personcapacity= Convert.ToInt32(Console.ReadLine());

            //            Room rooms = new Room(name,price,personcapacity);

            //            break;


            //        case "2":
            //            Console.WriteLine(" Id?: ");
            //            int id = Convert.ToInt32(Console.ReadLine());
            //            hotel.AddRoom(id);
            //            break;



            //        case "3":
            //            Console.WriteLine("Room Id?:");
            //            int roomid = Convert.ToInt32(Console.ReadLine());
            //            hotel.MakeReservation(roomid);
            //            break;




            //        case "4":

            //            foreach (var room5 in hotel.GetRooms())
            //            {
            //                Console.WriteLine(room5);
            //            }      


            //            break;

            //        case "0":
            //            check = false;
            //            break;
            //        default:
            //            Console.WriteLine("Bele bir sey yoxdur");
            //            break;
            //    }

            //} while (check);
            #endregion
        }
    }
}
