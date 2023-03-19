namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation of sortedlist  
            SortedList<string, string> FoodList = new SortedList<string, string>();
            //add the elements in sortedlist  
            FoodList.Add("Italy", "Pizza");
            FoodList.Add("Vietnam", "Bun Cha");
            FoodList.Add("German", "Schnitzel");
            FoodList.Add("Slovenia", "Bled Creme Cake");
            FoodList.Add("France", "Ratatouille");

            //display the elements of the sortedlist  
            Console.WriteLine("The food items on the international menu are:");
            foreach (KeyValuePair<string, string> bl in FoodList)
            {
                Console.WriteLine($"Key = {bl.Key}  Value={bl.Value}");
            }
            Console.WriteLine("What food would you like to the international menu?");
            string food = Console.ReadLine();
            Console.WriteLine("What country does the food come from?");
            string origin = Console.ReadLine();
            //check for value in list
            if (FoodList.ContainsValue(food))
                Console.WriteLine($"{food} is one of the values in your list");
            else
            {
                // check for origin key in list (can't have dups)
                if (FoodList.ContainsKey(origin))
                {
                    Console.WriteLine($"Only 1 food item on the menu can come from {origin} ");
                    FoodList.Remove(origin);
                    FoodList.Add(origin, food);
                    Console.WriteLine($"The present food item from {origin} has been removed and {food} has been added in its place.");
                }
                else
                {
                    FoodList.Add(food, origin);
                    Console.WriteLine($"{food} from {origin} was added to your list");
                }
            }
            Console.WriteLine("The items in the revised menu are ");
            foreach (KeyValuePair<string, string> bl in FoodList)
            {
                Console.WriteLine($"Key = {bl.Key}  Value={bl.Value}");
            }
        }
    }
}
