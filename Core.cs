﻿/*  <A text based survival game.>
    Copyright (C) <2024> <Frostyy>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>. */

using Items;
using Player;
using Survival;
using Shop;
namespace Core
{
    public class Game
    {
        // I don't know how any of this works, but it does
        readonly Random rand = new();

        public Character Player { get; }
        public CharacterMethods PlayerMethods { get; }
        public ShopCore Shop { get; }

        public ShopMethods ShopMethods { get; }

        public Form1 Form { get; }

        public Game(ShopCore shop, Character player, Form1 form)
        {
            Shop = shop;
            ShopMethods = new ShopMethods(shop, form);
            Player = player;
            PlayerMethods = new CharacterMethods(player, form);
            Form = form;
        }

        // Commands
        public void BeachCommands(string command)
        {
            switch (command)
            {
                case "eat":
                    PlayerMethods.EatFood();
                    break;
                case "drink":
                    PlayerMethods.DrinkWater();
                    break;
                case "explore":
                    var num = rand.Next(0, 101);

                    Explore(num);
                    PlayerMethods.Fatigue();
                    break;
                case "scavenge":
                    var scavenge = rand.Next(0, 7).ToString();

                    switch (scavenge)
                    {
                        case "2":
                            Item rock = new("Rock", 1, 1, "Assets/Images/Rock.png");
                            PlayerMethods.AddItem(rock);
                            break;
                        default:
                            Form.Output("You fail to find any rocks.");
                            break;
                    }
                    PlayerMethods.Fatigue();
                    break;
                case "help":
                    Form.Output("Beach Commands: eat, drink, explore, scavenge, help");
                    break;
                default:
                    Form.Output("Unknown command: " + command);
                    break;
            }
            Form.UpdateStats();
        }

        public void ForestCommands(string command)
        {
            switch (command)
            {
                case "eat":
                    PlayerMethods.EatFood();
                    break;
                case "drink":
                    PlayerMethods.DrinkWater();
                    break;
                case "explore":
                    var num = rand.Next(0, 101);

                    Explore(num);
                    PlayerMethods.Fatigue();
                    break;
                case "scavenge":
                    var scavenge = rand.Next(0, 17).ToString();

                    switch (scavenge)
                    {
                        case "2":
                            Item rock = new("Rock", 1, 1, "Assets/Images/Rock.png");
                            PlayerMethods.AddItem(rock);
                            break;
                        case "4":
                            Item branch = new("Branch", 1, 1, "Assets/Images/Branch.png");
                            PlayerMethods.AddItem(branch);
                            break;
                        case "6":
                            Food apple = new("Apple", 1, 1, "Assets/Images/Apple.png", 15);
                            PlayerMethods.AddItem(apple);
                            break;
                        default:
                            Form.Output("You fail to find any items.");
                            break;
                    }
                    PlayerMethods.Fatigue();
                    break;
                case "rest":
                    PlayerMethods.Rest();
                    break;
                case "help":
                    Form.Output("Forest Commands: eat, drink, explore, scavenge, rest, help")
                    break;
                default:
                    Form.Output("Unknown command: " + command);
                    break;

            }
            Form.UpdateStats();
        }

        public void PlainsCommands(string command)
        {
            switch (command)
            {
                case "eat":
                    PlayerMethods.EatFood();
                    break;
                case "drink":
                    PlayerMethods.DrinkWater();
                    break;
                case "explore":
                    var num = rand.Next(0, 101);

                    Explore(num);
                    PlayerMethods.Fatigue();
                    break;
                case "scavenge":
                    var scavenge = rand.Next(0, 7).ToString();

                    switch (scavenge)
                    {
                        case "2":
                            Item item = new("Rock", 1, 1, "Assets/Images/Rock.png");
                            PlayerMethods.AddItem(item);
                            break;
                        default:
                            Form.Output("You fail to find any rocks.");
                            break;
                    }
                    PlayerMethods.Fatigue();
                    break;
                case "help":
                    Form.Output("Plains Commands: eat, drink, explore, scavenge, help");
                    break;
                default:
                    Form.Output("Unknown command: " + command);
                    break;
            }
            Form.UpdateStats();
        }

        public void HillsCommands(string command)
        {
            switch (command)
            {
                case "eat":
                    PlayerMethods.EatFood();
                    break;
                case "drink":
                    PlayerMethods.DrinkWater();
                    break;
                case "explore":
                    var num = rand.Next(0, 101);

                    Explore(num);
                    PlayerMethods.Fatigue();
                    break;
                case "scavenge":
                    var scavenge = rand.Next(0, 7).ToString();

                    switch (scavenge)
                    {
                        case "2":
                            Item item = new("Rock", 1, 1, "Assets/Images/Rock.png");
                            PlayerMethods.AddItem(item);
                            break;
                        default:
                            Form.Output("You fail to find any rocks.");
                            break;
                    }
                    PlayerMethods.Fatigue();
                    break;
                case "help":
                    Form.Output("Hills Commands: eat, drink, explore, scavenge, help");
                    break;
                default:
                    Form.Output("Unknown command: " + command);
                    break;
            }
            Form.UpdateStats();
        }

        public void MountainsCommands(string command)
        {
            switch (command)
            {
                case "eat":
                    PlayerMethods.EatFood();
                    break;
                case "drink":
                    PlayerMethods.DrinkWater();
                    break;
                case "explore":
                    var num = rand.Next(0, 101);

                    Explore(num);
                    PlayerMethods.Fatigue();
                    break;
                case "scavenge":
                    var scavenge = rand.Next(0, 3).ToString();

                    switch (scavenge)
                    {
                        case "2":
                            Item item = new("Rock", 1, 1, "Assets/Images/Rock.png");
                            PlayerMethods.AddItem(item);
                            break;
                        default:
                            Form.Output("You fail to find any rocks.");
                            break;
                    }
                    PlayerMethods.Fatigue();
                    break;
                case "help":
                    Form.Output("Mountains Commands: eat, drink, explore, scavenge, help");
                    break;
                default:
                    Form.Output("Unknown command: " + command);
                    break;
            }
            Form.UpdateStats();
        }

        public void VillageCommands(string command)
        {
            switch (command)
            {
                case "eat":
                    PlayerMethods.EatFood();
                    break;
                case "drink":
                    PlayerMethods.DrinkWater();
                    break;
                case "explore":
                    var num = rand.Next(0, 101);

                    Explore(num);
                    PlayerMethods.Fatigue();
                    break;
                case "shop":
                    // TO DO
                    // ADD LOGIC

                    // Issue Here 
                    Form.shopGrid.Visible = true;
                    ShopMethods.UpdateShop();
                    break;
                case "scavenge":
                    var scavenge = rand.Next(0, 51).ToString();

                    switch (scavenge)
                    {
                        case "25":
                            Item item = new("Tender", 0.1, rand.Next(0, 11), "Assets/Images/Money.png");
                            PlayerMethods.AddItem(item);
                            break;
                        default:
                            Form.Output("You fail to find any items.");
                            break;
                    }
                    PlayerMethods.Fatigue();
                    break;
                case "help":
                    Form.Output("Village Commands: eat, drink, explore, scavenge, shop, help");
                    break;
                default:
                    Form.Output("Unknown command: " + command);
                    break;
            }
            Form.UpdateStats();
        }

        public void Explore(int num)
        {
            switch (num)
            {
                case <= 5:
                    if (Player.location == "Village")
                    {
                        Form.Output("You decide to explore the village more.");
                    }
                    else
                    {
                        Form.Output("You stumble upon a village and encounter a few shops.");
                        Player.location = "Village";
                    }
                    break;
                case > 10 and <= 45:
                    if (Player.location == "Forest")
                    {
                        Form.Output("You continue moving through the forest.");
                    }
                    else
                    {
                        Form.Output("You enter a forest.");
                        Player.location = "Forest";
                    }
                    break;
                case > 45 and <= 80:
                    if (Player.location == "Plains")
                    {
                        Form.Output("You continue moving through the plains.");
                    }
                    else
                    {
                        Form.Output("You enter a plains.");
                        Player.location = "Plains";
                    }
                    break;
                case > 80 and <= 90:
                    if (Player.location == "Hills")
                    {
                        Form.Output("You continue moving over the hills.");
                    }
                    else
                    {
                        Form.Output("You find yourself on a hill.");
                        Player.location = "Hills";
                    }
                    break;
                case > 90 and <= 100:
                    if (Player.location == "Mountains")
                    {
                        Form.Output("You continue navigating through the harsh mountains.");
                    }
                    else
                    {
                        Form.Output("You enter a mountainous area.");
                        Player.location = "Mountains";
                    }
                    break;
            }
        }
    }
}