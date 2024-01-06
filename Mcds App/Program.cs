using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string account = null;
            string name = null;
            string email = null;
            string password = null;
            string passwordcheck = null;
            string signin = null;
            string signinpw = null;

            Console.WriteLine("Welcome to the McDonald's App!");
            Console.WriteLine("   ");
            Console.WriteLine("Already have an account? Enter 'yes' to sign in or 'no' to create an account");
            account = Console.ReadLine();
            Console.WriteLine("   ");


            if (account == "no")
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();

                Console.WriteLine("   ");
                Console.WriteLine("Enter email:");
                email = Console.ReadLine();

                Console.WriteLine("   ");
                Console.WriteLine("Create a password:");
                password = Console.ReadLine();

                Console.WriteLine("   ");
                Console.WriteLine("Confirm password");
                passwordcheck = Console.ReadLine();

                if (passwordcheck == password)
                {
                    Console.WriteLine("   ");
                    Console.WriteLine("Your account has successfully been created! Enter 'yes' to sign in");
                    account = Console.ReadLine();
                }
                else
                {
                    do
                    {
                        Console.WriteLine("   ");
                        Console.WriteLine("uh oh! this password doesn't match.. lets try again");
                        passwordcheck = Console.ReadLine();
                    }
                    while (passwordcheck != password);

                    if (passwordcheck == password)
                    {
                        Console.WriteLine("   ");
                        Console.WriteLine("Your account has successfully been created! Enter 'yes' to sign in");
                        account = Console.ReadLine();

                    }

                }


            }

            Console.WriteLine("   ");
            Console.WriteLine("   ");
            Console.WriteLine("   ");
            Console.WriteLine("   ");

            if (account == "yes")
            {

                Console.WriteLine("   ");
                Console.WriteLine("Enter your name or email");
                signin = Console.ReadLine();

                Console.WriteLine("   ");

                Console.WriteLine("Enter your password");
                signinpw = Console.ReadLine();
                Console.WriteLine("   ");

                if (((signin == name) && (signinpw == password)) || ((signin == email) && (signinpw == password)))
                {
                    Console.WriteLine("   ");
                    Console.WriteLine("   ");
                    Console.WriteLine("Welcome {0}!", name);

                }
                else
                {

                    do
                    {
                        Console.WriteLine("   ");
                        Console.WriteLine("uh oh! the name or password is incorrect");
                        Console.WriteLine("   ");
                        Console.WriteLine("Enter your name or email");
                        signin = Console.ReadLine();
                        Console.WriteLine("   ");
                        Console.WriteLine("Enter your password");
                        signinpw = Console.ReadLine();
                    }
                    while (signinpw != password);

                    if (((signin == name) && (signinpw == password)) || ((signin == email) && (signinpw == password)))
                    {
                        Console.WriteLine("   ");
                        Console.WriteLine("   ");
                        Console.WriteLine("   ");
                        Console.WriteLine("   ");
                        Console.WriteLine("Welcome {0}!", name);

                    }
                }

            }

            double points = 0;
            string ordering = null;
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("   ");
            Console.WriteLine("Enter 'menu' to view our menu and place an order");
            Console.WriteLine("_______________________________________________________________________");

            Console.WriteLine("   ");
            Console.WriteLine("Enter 'rewards' to check your McDonalds Rewards! *NEW");
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("   ");
            ordering = Console.ReadLine();
            Console.WriteLine("   ");



            if (ordering == "menu")
            {

                Console.WriteLine("   ");
                Console.WriteLine("Food Options:                    Drink Options:                  Dessert Options:");
                Console.WriteLine("1 – Cheeseburger    ($2.29)       1 – Coffee       ($1.78)        1 - Ice Cream Cone     ($1.88)");
                Console.WriteLine("2 – Hamburger       ($2.29)       2 – Tea          ($1.78)        2 - Mini Apple Pie     ($1.79)");
                Console.WriteLine("3 – Junior Chicken  ($2.49)       3 – Milk         ($2.19)        3 - Oreo McFlurry      ($3.49)");
                Console.WriteLine("4 – Big Mac         ($5.29)       4 – Choc Milk    ($2.19)        4 - Smarties McFlurry  ($3.49)");
                Console.WriteLine("5 – Filet O Fish    ($4.29)       5 – Pop          ($2.49)        5 - Fudge Sundae       ($3.59)");
                Console.WriteLine("6 – Qtr Pounder     ($5.29)       6 – Iced Coffee  ($2.29)        6 - Banana Choc Muffin ($2.79)");
                Console.WriteLine("7 – 6 pc Nuggets    ($4.49)       7 – Apple Juice  ($1.89)        7 - Blueberry Muffin   ($2.79)");
                Console.WriteLine("8 – 10 pc Nuggets   ($5.29)       8 – Orange Juice ($1.89)        8 - Fudge Sundae       ($3.49)");
                Console.WriteLine("9 – Fries           ($3.49)       9 - Americano    ($2.49)        9 - Caramel Sundae     ($3.49)");
                Console.WriteLine("10 – Chicken Wrap   ($4.49)       10 - Mocha       ($2.19)");
                Console.WriteLine("11 – SausEgg Muffin ($3.29)");

                Console.WriteLine("   ");
                Console.WriteLine("   ");
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("   ");
                    Console.WriteLine("   ");

                }
                double dc = 0;
                string combo = null;
                double sc = 0; //sauce 1
                double ss = 0; //sauce 2
                double fn = 0; //number of food items
                Console.WriteLine("How many food items will you be ordering today?");
                fn = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("   ");
                double cost = 0;
                double f = 0;
                for (int i = 1; i <= fn; i++)
                {
                    Console.WriteLine("  ");
                    Console.WriteLine("Enter which food item you would like to order:");
                    f = Convert.ToDouble(Console.ReadLine());

                    if (f == 1)
                    {
                        cost = cost + 2.29;
                    }
                    if (f == 2)
                    {
                        cost = cost + 2.29;
                    }
                    if (f == 3)
                    {
                        cost = cost + 2.49;
                        Console.WriteLine("   ");
                        Console.WriteLine("Would you like to make that a combo? A combo includes a sandwich, fries, and drink for $2 less");
                        combo = Console.ReadLine();
                        if (combo == "yes")
                        {
                            cost = cost + 1.49;
                            Console.WriteLine("   ");
                            Console.WriteLine("What drink would you like with the combo?");
                            dc = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    if (f == 4)
                    {
                        cost = cost + 5.29;
                        Console.WriteLine("   ");
                        Console.WriteLine("Would you like to make that a combo? A combo includes a sandwich, fries, and drink for $2 less");
                        combo = Console.ReadLine();
                        if (combo == "yes")
                        {
                            cost = cost + 1.49;
                            Console.WriteLine("   ");
                            Console.WriteLine("What drink would you like with the combo?");
                            dc = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    if (f == 5)
                    {
                        cost = cost + 4.29;
                        Console.WriteLine("   ");
                        Console.WriteLine("Would you like to make that a combo? A combo includes a sandwich, fries, and drink for $2 less");
                        combo = Console.ReadLine();
                        if (combo == "yes")
                        {
                            cost = cost + 1.49;
                            Console.WriteLine("   ");
                            Console.WriteLine("What drink would you like with the combo?");
                            dc = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    if (f == 6)
                    {
                        cost = cost + 5.29;
                        Console.WriteLine("   ");
                        Console.WriteLine("Would you like to make that a combo? A combo includes a sandwich, fries, and drink for $2 less");
                        combo = Console.ReadLine();
                        if (combo == "yes")
                        {
                            cost = cost + 1.49;
                            Console.WriteLine("   ");
                            Console.WriteLine("What drink would you like with the combo?");
                            dc = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    if (f == 7)
                    {
                        cost = cost + 4.49;

                        Console.WriteLine("What nugget sauce would you like with that?");
                        Console.WriteLine("   ");
                        Console.WriteLine("1. Sweet and sour *top seller!");
                        Console.WriteLine("2. Barbeque");
                        Console.WriteLine("3. Hot mustard");
                        Console.WriteLine("4. Habenaro");
                        Console.WriteLine("5. Honey");
                        Console.WriteLine("6. Spicy buffalo");
                        Console.WriteLine("7. No sauce");
                        sc = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("   ");
                        Console.WriteLine("Would you like to make that a combo? A combo includes a sandwich, fries, and drink for $2 less");
                        combo = Console.ReadLine();
                        if (combo == "yes")
                        {
                            cost = cost + 1.49;
                            Console.WriteLine("   ");
                            Console.WriteLine("What drink would you like with the combo?");
                            dc = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    if (f == 8)
                    {
                        cost = cost + 5.29;
                        Console.WriteLine("What 2 nugget sauces would you like with that?");
                        Console.WriteLine("   ");
                        Console.WriteLine("1. Sweet and sour *top seller!");
                        Console.WriteLine("2. Barbeque");
                        Console.WriteLine("3. Hot mustard");
                        Console.WriteLine("4. Habenaro");
                        Console.WriteLine("5. Honey");
                        Console.WriteLine("6. Spicy buffalo");
                        Console.WriteLine("7. No sauce");
                        sc = Convert.ToDouble(Console.ReadLine());
                        ss = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("   ");
                        Console.WriteLine("Would you like to make that a combo? A combo includes a sandwich, fries, and drink for $2 less");
                        combo = Console.ReadLine();
                        if (combo == "yes")
                        {
                            cost = cost + 1.49;
                            Console.WriteLine("   ");
                            Console.WriteLine("What drink would you like with the combo?");
                            dc = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    if (f == 9)
                    {
                        Console.WriteLine("   ");
                        Console.WriteLine("What size will that be?");
                        Console.WriteLine("1. Small ($2.49)");
                        Console.WriteLine("2. Medium ($3.49)");
                        Console.WriteLine("3. Large ($4.29)");
                        double fs = 0; // fries size
                        fs = Convert.ToDouble(Console.ReadLine());
                        if (fs == 1)
                        {
                            cost = cost + 2.49;
                        }
                        if (fs == 2)
                        {
                            cost = cost + 3.49;
                        }
                        if (fs == 3)
                        {
                            cost = cost + 4.49;
                        }

                    }
                    if (f == 10)
                    {
                        cost = cost + 4.49;
                        double ck = 0;
                        Console.WriteLine("   ");
                        Console.WriteLine("Would you like the chicken crispy or grilled?");
                        Console.WriteLine("1. Crispy");
                        Console.WriteLine("2. Grilled");
                        ck = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Would you like to make that a combo? A combo includes a sandwich, fries, and drink for $2 less");
                        combo = Console.ReadLine();
                        if (combo == "yes")
                        {
                            cost = cost + 1.49;
                            Console.WriteLine("   ");
                            Console.WriteLine("What drink would you like with the combo?");
                            dc = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    if (f == 11)
                    {
                        cost = cost + 3.29;
                        Console.WriteLine("   ");
                        Console.WriteLine("Would you like to make that a combo? A combo includes a sandwich, fries, and drink for $2 less");
                        combo = Console.ReadLine();
                        if (combo == "yes")
                        {
                            cost = cost + 1.49;
                            Console.WriteLine("   ");
                            Console.WriteLine("What drink would you like with the combo?");
                            dc = Convert.ToDouble(Console.ReadLine());
                        }
                    }

                }






                Console.WriteLine("  ");


                if (dc == 1)
                {

                    cost = cost + 1.78;

                }
                if (dc == 2)
                {


                    cost = cost + 1.78;

                }
                if (dc == 3)
                {

                    cost = cost + 2.19;

                }
                if (dc == 4)
                {

                    cost = cost + 2.19;

                }
                if (dc == 5)
                {
                    cost = cost + 2.49;
                }
                if (dc == 6)
                {
                    cost = cost + 2.29;
                }
                if (dc == 7)
                {
                    cost = cost + 1.89;
                }
                if (dc == 8)
                {
                    cost = cost + 2.29;
                }
                if (dc == 9)
                {
                    cost = cost + 2.49;
                }
                if (dc == 10)
                {
                    cost = cost + 2.19;
                }








                double dn = 0;
                double d = 0;
                double s = 0;
                double cream = 0;
                double sugar = 0;
                Console.WriteLine("   ");
                Console.WriteLine("How many drinks would you like to order?");
                dn = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("   ");
                for (int j = 1; j <= dn; j++)
                {
                    Console.WriteLine("  ");

                    Console.WriteLine("Enter which drinks you would like to order:");
                    d = Convert.ToDouble(Console.ReadLine());
                    if (d == 1)
                    {
                        Console.WriteLine("Enter the size you would like");
                        Console.WriteLine("1. Small ($1.28)");
                        Console.WriteLine("2. Medium ($1.78)");
                        Console.WriteLine("3. Large ($2.38)");
                        s = Convert.ToDouble(Console.ReadLine());
                        if (s == 1)
                        {
                            cost = cost + 1.28;
                        }
                        if (s == 2)
                        {
                            cost = cost + 1.78;
                        }
                        if (s == 3)
                        {
                            cost = cost + 2.38;
                        }
                        Console.WriteLine("How many creams?");
                        cream = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("How many sugars?");
                        sugar = Convert.ToDouble(Console.ReadLine());

                    }
                    if (d == 2)
                    {
                        double teaflavour = 0;
                        Console.WriteLine("Which tea flavour would you like?");
                        Console.WriteLine("1. Orange Pekoe *top seller!");
                        Console.WriteLine("2. Earl Gray");
                        Console.WriteLine("3. Mint");
                        Console.WriteLine("4. Green");
                        teaflavour = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the size you would like");
                        Console.WriteLine("1. Small ($1.28)");
                        Console.WriteLine("2. Medium ($1.78)");
                        Console.WriteLine("3. Large ($2.38)");
                        s = Convert.ToDouble(Console.ReadLine());
                        if (s == 1)
                        {
                            cost = cost + 1.28;
                        }
                        if (s == 2)
                        {
                            cost = cost + 1.78;
                        }
                        if (s == 3)
                        {
                            cost = cost + 2.38;
                        }
                    }
                    if (d == 3)
                    {

                        cost = cost + 2.19;

                    }
                    if (d == 4)
                    {

                        cost = cost + 2.19;

                    }
                    if (d == 5)
                    {
                        Console.WriteLine("Enter the size you would like");
                        Console.WriteLine("1. Small ($1.99)");
                        Console.WriteLine("2. Medium ($2.49)");
                        Console.WriteLine("3. Large ($2.99)");
                        s = Convert.ToDouble(Console.ReadLine());
                        if (s == 1)
                        {
                            cost = cost + 1.99;
                        }
                        if (s == 2)
                        {
                            cost = cost + 2.49;
                        }
                        if (s == 3)
                        {
                            cost = cost + 2.99;
                        }
                    }
                    if (d == 6)
                    {
                        Console.WriteLine("Enter the size you would like");
                        Console.WriteLine("1. Small ($1.79)");
                        Console.WriteLine("2. Medium ($2.29)");
                        Console.WriteLine("3. Large ($2.79)");
                        s = Convert.ToDouble(Console.ReadLine());
                        if (s == 1)
                        {
                            cost = cost + 1.79;
                        }
                        if (s == 2)
                        {
                            cost = cost + 2.29;
                        }
                        if (s == 3)
                        {
                            cost = cost + 2.79;
                        }
                    }
                    if (d == 7)
                    {
                        Console.WriteLine("Enter the size you would like");
                        Console.WriteLine("1. Small ($1.39)");
                        Console.WriteLine("2. Medium ($1.89)");
                        Console.WriteLine("3. Large ($2.39)");
                        s = Convert.ToDouble(Console.ReadLine());
                        if (s == 1)
                        {
                            cost = cost + 1.39;
                        }
                        if (s == 2)
                        {
                            cost = cost + 1.89;
                        }
                        if (s == 3)
                        {
                            cost = cost + 2.39;
                        }
                    }
                    if (d == 8)
                    {
                        Console.WriteLine("Enter the size you would like");
                        Console.WriteLine("1. Small ($1.39)");
                        Console.WriteLine("2. Medium ($1.89)");
                        Console.WriteLine("3. Large ($2.39)");
                        s = Convert.ToDouble(Console.ReadLine());
                        if (s == 1)
                        {
                            cost = cost + 1.39;
                        }
                        if (s == 2)
                        {
                            cost = cost + 1.89;
                        }
                        if (s == 3)
                        {
                            cost = cost + 2.39;
                        }
                    }
                    if (d == 9)
                    {
                        Console.WriteLine("Enter the size you would like");
                        Console.WriteLine("1. Small ($1.39)");
                        Console.WriteLine("2. Medium ($1.89)");
                        Console.WriteLine("3. Large ($2.39)");
                        s = Convert.ToDouble(Console.ReadLine());
                        if (s == 1)
                        {
                            cost = cost + 1.99;
                        }
                        if (s == 2)
                        {
                            cost = cost + 2.49;
                        }
                        if (s == 3)
                        {
                            cost = cost + 2.99;
                        }
                    }
                    if (d == 10)
                    {
                        Console.WriteLine("Enter the size you would like");
                        Console.WriteLine("1. Small ($1.39)");
                        Console.WriteLine("2. Medium ($1.89)");
                        Console.WriteLine("3. Large ($2.39)");
                        s = Convert.ToDouble(Console.ReadLine());
                        if (s == 1)
                        {
                            cost = cost + 1.79;
                        }
                        if (s == 2)
                        {
                            cost = cost + 2.19;
                        }
                        if (s == 3)
                        {
                            cost = cost + 2.69;
                        }
                    }

                }







                double dsn = 0; //number of dessert items
                Console.WriteLine("   ");
                Console.WriteLine("How many dessert items will you be ordering today?");
                dsn = Convert.ToDouble(Console.ReadLine());


                double ds = 0;
                for (int k = 1; k <= dsn; k++)
                {
                    Console.WriteLine("   ");
                    Console.WriteLine("Enter which dessert item you would like to order:");
                    ds = Convert.ToDouble(Console.ReadLine());
                    if (ds == 1)
                    {
                        cost = cost + 1.88;
                    }
                    if (ds == 2)
                    {
                        cost = cost + 1.79;
                    }
                    if (ds == 3)
                    {
                        cost = cost + 3.49;
                    }
                    if (ds == 4)
                    {
                        cost = cost + 3.49;
                    }
                    if (ds == 5)
                    {
                        cost = cost + 3.59;
                    }
                    if (ds == 6)
                    {
                        cost = cost + 2.79;
                    }
                    if (ds == 7)
                    {
                        cost = cost + 2.79;
                    }
                    if (ds == 8)
                    {
                        cost = cost + 3.49;
                    }
                    if (ds == 9)
                    {
                        cost = cost + 3.49;
                    }

                }
                Console.WriteLine("   ");
                Console.WriteLine("Subtotal: $" + cost);
                double tax = 0;
                tax = cost * 0.13;
                Math.Round(tax, 2);
                double total = 0;
                total = cost + tax;
                Math.Round(total, 2);
                Console.WriteLine("Tax: $" + Math.Round(tax, 2));
                Console.WriteLine("Total: $" + Math.Round(total, 2));
                Console.WriteLine("   ");
                Random rnd = new Random();
                int code = rnd.Next(1000, 9999);
                Console.WriteLine("Your order code is: " + code);
                Console.WriteLine("   ");
                points = points + (100 * Math.Round(cost));
                Console.WriteLine("Points collected: {0} *You receive 100 points for every pre tax dollar you spend!", points);
                Console.WriteLine("For more information on points and rewards, enter 'rewards'");
                Console.WriteLine("   ");
                Console.WriteLine("   ");
                Console.WriteLine("   ");
                ordering = Console.ReadLine();




            }

            if (ordering == "rewards")
            {
                Console.WriteLine("   ");
                Console.WriteLine("   ");
                Console.WriteLine("Your points!: " + points);
                Console.WriteLine("   ");
                Console.WriteLine("You receive 100 points for every pre tax dollar your spend. These points can be redeemed for free food!");
                Console.WriteLine("   ");
                Console.WriteLine("   ");
                Console.WriteLine("What can I redeem with my current points?");
                Console.WriteLine("   ");
                if (points < 1500)
                {
                    Console.WriteLine("Not enough points yet :(");
                }
                if (points > 1500)
                {
                    Console.WriteLine("-Ice Cream Cone (1500 points)");
                    Console.WriteLine("-Cheeseburger (1500 points)");
                    Console.WriteLine("-Medium Coffee or Tea (1500 points)");
                }
                if (points > 2000)
                {
                    Console.WriteLine("-Mcflurry (2000 points)");
                    Console.WriteLine("-Muffin (2000 points)");
                    Console.WriteLine("-Small fries (2000 points)");
                }
                if (points > 3500)
                {
                    Console.WriteLine("-Junior Chicken (3500 points)");
                }
                if (points > 5000)
                {
                    Console.WriteLine("-Big Mac (5000 points)");
                    Console.WriteLine("-Qtr Pounder (5000 points)");
                    Console.WriteLine("-10 pc Nuggets (5000 points)");
                }
                if (points > 14000)
                {
                    Console.WriteLine("-A combo with ANY sandwich! (14000 points)");
                }

                Console.WriteLine("   ");
                Console.WriteLine("   ");
                Console.WriteLine("How many points do I need to redeem other items?");
                Console.WriteLine("   ");
                if (points < 1500)
                {
                    Console.WriteLine("-Ice Cream Cone (1500 points)");
                    Console.WriteLine("-Cheeseburger (1500 points)");
                    Console.WriteLine("-Medium Coffee or Tea (1500 points)");
                }
                if (points < 2000)
                {
                    Console.WriteLine("-Mcflurry (2000 points)");
                    Console.WriteLine("-Muffin (2000 points)");
                    Console.WriteLine("-Small fries (2000 points)");
                }
                if (points < 3500)
                {
                    Console.WriteLine("-Junior Chicken (3500 points)");
                }
                if (points < 5000)
                {
                    Console.WriteLine("-Big Mac (5000 points)");
                    Console.WriteLine("-Qtr Pounder (5000 points)");
                    Console.WriteLine("-10 pc Nuggets (5000 points)");
                }
                if (points < 14000)
                {
                    Console.WriteLine("-A combo with ANY sandwich! (14000 points)");
                }

                Console.WriteLine("   ");
                Console.WriteLine("   ");
                Random rnd = new Random();
                int pointscode = rnd.Next(1000, 9999);
                Console.WriteLine("Your 4 digit POINTS code: " + pointscode);
                Console.WriteLine("   ");
                Console.WriteLine("Your POINTS QR code:");
                Console.WriteLine("   ");

                /*Console.WriteLine("■■■ ■■ ■■■  ■■ ■");
                Console.WriteLine("■■ ■■ ■ ■■■  ■■■");
                Console.WriteLine("■■ ■■ ■■■ ■ ■■■■");
                Console.WriteLine("■ ■■ ■■ ■■ ■■ ■■");
                Console.WriteLine("■■ ■■ ■■■■ ■ ■■■");
                Console.WriteLine("■ ■■■ ■■ ■  ■■■■");
                Console.WriteLine("■■■ ■ ■■■ ■■ ■■■");
                Console.WriteLine("■■ ■ ■■■■ ■ ■■ ■");*/
            }






            Console.ReadLine();

        }




    }
}




