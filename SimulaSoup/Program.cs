namespace Program
{
    class Program
    {
        enum Type
        {
            Soup,
            Stew,
            Gumbo,
            Null
        }
        enum MainI
        {
            Mushrooms,
            Chicken,
            Carrots,
            Potatoes,
            Null
        }
        enum Seasoning
        {
            Spicy,
            Salty,
            Sweet,
            Null
        }

        static void Main(string[] args)
        {
            Type TypeIngredient = Type.Null;
            MainI MainIngredient = MainI.Null;
            Seasoning SeasoningIngredient = Seasoning.Null;

            (Type type, MainI main, Seasoning seasoning) soup = (TypeIngredient, MainIngredient, SeasoningIngredient);


            while (TypeIngredient == Type.Null)
            {
                TypeIngredient = ChooseTypeIngredient();
                soup.type = TypeIngredient;
            }
            while (MainIngredient == MainI.Null)
            {
                MainIngredient = ChooseMainIngredient();
                soup.main = MainIngredient;
            }
            while (SeasoningIngredient == Seasoning.Null)
            {
                SeasoningIngredient = ChooseSeasoningIngredient();
                soup.seasoning = SeasoningIngredient;
            }


            System.Console.WriteLine($"{soup.seasoning} {soup.main} {soup.type}");

            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);



            Type ChooseTypeIngredient()
            {

                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("Choose an ingridient");
                System.Console.WriteLine($"{((int)Type.Soup) + 1} - {Type.Soup}");
                System.Console.WriteLine($"{((int)Type.Stew) + 1} - {Type.Stew}");
                System.Console.WriteLine($"{((int)Type.Gumbo) + 1} - {Type.Gumbo}");
                int choice = Convert.ToInt32(System.Console.ReadLine());
                Type typeIngredient = choice switch
                {
                    1 => Type.Soup,
                    2 => Type.Stew,
                    3 => Type.Gumbo,
                    _ => Type.Null
                };
                return typeIngredient;
            }


            MainI ChooseMainIngredient()
            {

                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("Choose an ingridient");
                System.Console.WriteLine($"{((int)MainI.Mushrooms) + 1} - {MainI.Mushrooms}");
                System.Console.WriteLine($"{((int)MainI.Chicken) + 1} - {MainI.Chicken}");
                System.Console.WriteLine($"{((int)MainI.Carrots) + 1} - {MainI.Carrots}");
                System.Console.WriteLine($"{((int)MainI.Potatoes) + 1} - {MainI.Potatoes}");
                int choice = Convert.ToInt32(System.Console.ReadLine());
                MainI mainIngridient = choice switch
                {
                    1 => MainI.Mushrooms,
                    2 => MainI.Chicken,
                    3 => MainI.Carrots,
                    4 => MainI.Potatoes,
                    _ => MainI.Null
                };
                return mainIngridient;
            }
            Seasoning ChooseSeasoningIngredient()
            {

                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("Choose an ingridient");
                System.Console.WriteLine($"{((int)Seasoning.Spicy) + 1} - {Seasoning.Spicy}");
                System.Console.WriteLine($"{((int)Seasoning.Salty) + 1} - {Seasoning.Salty}");
                System.Console.WriteLine($"{((int)Seasoning.Sweet) + 1} - {Seasoning.Sweet}");

                int choice = Convert.ToInt32(System.Console.ReadLine());
                Seasoning seasoningIngredient = choice switch
                {
                    1 => Seasoning.Spicy,
                    2 => Seasoning.Salty,
                    3 => Seasoning.Sweet,
                    _ => Seasoning.Null
                };
                return seasoningIngredient;
            }

        }
    }
}