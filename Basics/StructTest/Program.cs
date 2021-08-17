void PrintRoom(in HotelRoom room)
{
	string status = room.Taken ? "occupied" : "available";
	Console.WriteLine($"Room {room.Number} is currently {status}.");
}

void ReserveRoom(ref HotelRoom room, int days)
{
	if(room.Taken)
		Console.WriteLine("Reservation failed!");
	else
	{
		room.Taken = true;
		Console.WriteLine("Total Payment: {0:0.00}", days * room.GetRate());
	}
}

HotelRoom myroom;
myroom.Number = 504;
myroom.Beds = 2;
myroom.Taken = false;
PrintRoom(myroom);
Console.WriteLine("Reserving this room...");
ReserveRoom(ref myroom, 1);
PrintRoom(myroom);

