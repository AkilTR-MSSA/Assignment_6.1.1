House house1 = new House(1234, "Main Street", House.HouseType.Ranch);
House house2 = new House(5678, "Average Avenue", House.HouseType.Colonial);
House house3 = new House(18457, "Boring Boulevard", House.HouseType.Victorian);
House house4 = new House(1400, "Roaring Road", House.HouseType.Bungalow);
House house5 = new House(28, "Crazy Court", House.HouseType.Craftsman);

HouseList houseList = new HouseList();
houseList.Append(house1);
houseList.Append(house2);
houseList.Append(house3);
houseList.Append(house4);
houseList.Append(house5);
houseList.Search(1400);