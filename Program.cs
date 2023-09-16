


{
    int sodas = 100;
    Console.WriteLine("Hello, how many sodas have been sold today? 100 are in stock.");


    sodas = int.Parse(Console.ReadLine());



    if (sodas >= 101)
    {
        Console.WriteLine("The value is too high, stock will not be adjusted.");




    }
    else
    {
        Console.WriteLine("There are " + (100 - sodas) + " sodas left.");

    }


    int chips = 40;
    Console.WriteLine("How many Chips have been sold today? 40 are in stock.");


    chips = int.Parse(Console.ReadLine());


    if (chips >= 41)
    {


        Console.WriteLine("The value is too high, stock will not be adjsuted.");


    }
    else
    {
        Console.WriteLine("there are " + (40 - chips) + "chips left.");

    }


    {
        Console.WriteLine("How many Candy have been sold today? 60 are in stock.");


        int candy = int.Parse(Console.ReadLine());
        if (candy >= 61)
        {
            Console.WriteLine("The value is too high, stock will not be adjusted.");
        }


        else
        {


            Console.WriteLine("there are " + (60 - candy) + " Candy left.");







        }


        Console.WriteLine(" thank you for filling out the values. Here's what need to be restocked ");

        if (chips >= 20)
        {


            Console.WriteLine(" chips need to be restocked ");

        }



        if (sodas >= 40)

        {


            Console.WriteLine("sodas need to be restocked");
        }


        if (candy >= 40)

        { 
            Console.WriteLine("candy need to be restocked");
        }
    }
}



