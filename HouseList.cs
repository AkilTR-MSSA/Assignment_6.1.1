using System;

public class HouseNode
{
	public HouseNode(House house, HouseNode next)
	{
		this.house = house;
		this.next = next;
	}
	public House house;
	public HouseNode next;
}
public class HouseList
{
	private HouseNode head;
	private HouseNode tail;
	private int size;
	public int Size 
	{ 
		get { return size; } 
	}
	public HouseList() 
	{
		head = null;
		tail = null;
		size = 0;
	}

	public bool IsEmpty()
	{
		return size == 0;
	}
	public void Append(House house)
	{
		HouseNode node = new HouseNode(house, null);
		if (IsEmpty()) 
		{
			head = node;
		}
		else
		{
			tail.next = node;
		}
		tail = node;
		size++;
	}
    public void Search(int houseNumber)
    {
		if (IsEmpty()) 
		{
            Console.WriteLine("List is empty!");
			return;
		}
		HouseNode curr = head;
		while (curr != null)
		{
			if (curr.house.Number == houseNumber)
			{
                Console.WriteLine(curr.house.ToString());
				return;
			}
			curr = curr.next;
		}
        Console.WriteLine("House not found!");
	}
}