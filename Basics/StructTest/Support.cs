struct HotelRoom
{
	public int Number;
	public int Beds;
	public bool Taken;

	public double GetRate()
	{
		return 850 + 100 * Beds;
	}

}

