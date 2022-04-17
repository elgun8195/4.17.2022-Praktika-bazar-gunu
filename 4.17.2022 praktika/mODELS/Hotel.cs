using System;
using System.Collections.Generic;
using System.Text;

namespace _4._17._2022_praktika.mODELS
{
    class Hotel
    {
        public string Name { get; set; }
        private Room[] _rooms = new Room[0];
       

        public Hotel(string name)
        {
            Name = name;

        }
        public void AddRoom0(int id)
        {


                foreach (var room in _rooms)
                {
                    if (room.Id == id)
                    {
                        Array.Resize(ref _rooms, _rooms.Length + 1);
                        _rooms[_rooms.Length - 1] = room;
                    }
                }

        }
        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[_rooms.Length - 1] = room;
        }
        public void MakeReservation(int roomid)
        {
            foreach (var item in _rooms)
            {
                if (item.Id==roomid)
                {
                    if (item.IsAviable==true)
                    {
                        item.IsAviable = false;
                        Console.WriteLine("Room is reserved");
                    }
                    else
                    {
                        Console.WriteLine("room is full");
                    }
                }
            }
        }

        public Room[] GetRooms()
        {
            return _rooms;
        }
    }
}
