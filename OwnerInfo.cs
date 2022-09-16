class OwnerInfo
{
    public static void MenuB()
    {
        string OwnerName =  InputOwnerName();
        string OwnerSurname = InputOwnerSurname();
        string OwnerPPC = InputOwnerPPC();

        PrintOwnerInformation(OwnerName,OwnerSurname,OwnerPPCShopAddress);

    }

    static string InputOwnerName()
    {
       Console.Write("Input your name(Owner):");
       return Console.ReadLine();
    }

    static string InputOwnerSurname()
    {
        Console.Write("Input your surname(Owner):");
        return Console.ReadLine();
    }

    static string InputOwnerPPC()
    {
        Console.Write("Input your number PPC:");
        return Console.ReadLine();
    }



    static void PrintShopInformation(string OwnerName,string OwnerSurname,string OwnerPPC)
    {
        Console.WriteLine();
        Console.WriteLine("**********************************");
        Console.WriteLine("Your name is: {0} {1}", OwnerName, OwnerSurname);
        Console.WriteLine("Your number PPC is:{0}",OwnerPPC);
        Console.WriteLine("**********************************");
    }       
}