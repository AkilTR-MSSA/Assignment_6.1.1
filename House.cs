using System;

public class House
{
	public enum HouseType
	{
		Ranch,
		Colonial,
		Victorian,
		Cottage,
		Farmhouse,
		Townhouse,
		Craftsman,
		Bungalow,
		Prairie
	}
	public House()
	{
	}
	public House(int houseNumber, string houseAddress, HouseType houseType)
	{
		Number = houseNumber;
		Address = houseAddress;
		Type = houseType;
	}
	public int Number { get; set; }
	public string Address { get; set; }
	public HouseType Type { get; set; }

    public override string ToString()
    {
        return $"House: {Number} {Address}, Type: {Type}";
    }
}
