class ShopInfo
{
    public static void MenuA()
    {
        string Bugget =  InputBugget();
        string ShopName = InputShopName();
        string ShopAddress = InputShopAddress();

        PrintShopInformation(Bugget,ShopName,ShopAddress);

    }

    static string InputBugget()
    {
       return Console.ReadLine();
    }

    static string InputShopName()
    {
        Console.Write("Input your shop name:");
        return Console.ReadLine();
    }

    static string InputShopAddress()
    {
        Console.Write("Input your shop address:");
        return Console.ReadLine();
    }



    static void PrintShopInformation(string Bugget,string ShopName,string ShopAddress)
    {
        Console.WriteLine();
        Console.WriteLine("**********************************");
        Console.WriteLine("Your bugget is: {0}", Bugget);
        Console.WriteLine("Your shop name is: {0}", ShopName);
        Console.WriteLine("Your shop address is:",ShopAddress);
        Console.WriteLine("**********************************");
    }       
}
