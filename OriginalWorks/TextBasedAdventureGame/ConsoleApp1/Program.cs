using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Creative input form
 * Lily
 * Brandon
 * Stephen
 * Mekkhi
 */

namespace ConsoleApp1
{
    class Program
    {
        static public List<int> droppedItemsLocationOverworld = new List<int>();
        static public List<string> droppedItemsIdOverworld = new List<string>();

        static public List<string> bag = new List<string>();

        static public bool gotHolyWater = false;
        static public bool chestUnlocked = false;
        static public bool dragonKilled = false;
        static public bool inDragonFight = false;
        static public bool hasLantern = false;
        static public bool isDrunk = false;
        static public bool isVampire = false;
        static public bool hasWaterBreathing = false;
        static public bool hasHorse = false;
        static public bool hasArmor = false;

        static public string ErrorMsg = "";
        static public string talkMsg = "";
        static public int silver = 50;
        static public bool shipGold = false;
        static public string horseName = "";
        
        static public string[] knownItems = new string[]
        {
            "sword", // 15
            "water breathing potion", //0
            "armor", // 40
            "holy water", // 0
            "horse", // 2 plus items
            "shield", // 10
            "booze", // -10
            "healing potion", // 30
            "bow and arrow", //20
            "dagger", // 5
            "throwing axe", // 10
            "lantern", //0
            "book", //10
            "key", //0
            "frieball scroll" //15
        };
        static public int[] map = new int[]
            {
                0, 1, 2, 3,
                4, 7, 6, 7,
                8, 9, 10, 11,
                12, 13, 14, 17,
                16
            };
        static public int mapLocation = map[6];
        static public string[] mapNames = new string[]
        {
                "Shipwreck", //0
                "Docks", //1
                "Monastery", //2
                "Graveyard", //3
                "Tavern", //4
                "Merchants Guild", //5
                "Town Square", //6
                "Forest", //7
                "Castle", //8
                "Knight's Armory", //9
                "Wizard's Tower", //10
                "Ancient Ruins", //11
                "Vampire's Cave", //12
                "Farm", //13
                "Stables", //14
                "Dragon's Mountain", //15
                "BONUS Bowling Alley" //16
        };
        static public string[] mapMessage = new string[]
        {
            "You are at the bottom of the ocean, in the sunken ship, The Titanic. You see    some sharks around you but they " +
            "ignore you. Inside the ship you see what might  be a chest. When you open the chest you see 20 silver.", // 0
            "You see some orcs carrying some boxes off of the docked ships and heading south.You see some navy men heading " +
            "to the south east. You see some people who look like they run the dock", // 1
            "You see some monks meditating. He looks a little thirsty.", // 2
            "There is a fog so it is hard to see. But you walk into a graveyard where you can make out a tombstone in the shape of '#1'. It reads 'RIP Smithy Werbenman      Jensen'. ", //3
            "When you walk into the tavern you see they are selling booze. 5 silver coins    each. ", //4
            "When you walk into the Merchant's Guild you see that there is a small fair in    progress. They are trading all kinds " +
            "of trinkets and knick knacks. They have       swords, axes shields, pieces of armor. A man walks up to you asking what " +
            "you     want to buy.", //5
            "You are in the town square and there is a big commotion.  The princess has gone missing in the last 12 hours. You hear all these people shouting" +
            " 'Could it have been the Vampires','Maybe it was a creature that lived in the forest',  'or the Dragon did it.'", //6
            "You walk into the forest and see Centaurs galloping around.", //7
            "The King is trying to calm down The Queen but she is crying. She is visable torn over the disapearence of her daughter. " +
            "The King does not seem to notice your   entrance", //8
            "As you walk into the Knight's Armory you see many sets of armor and swords. As  you go and reach for one a knight" +
            " stops you. 'These suits are for knights of the Kingdom ONLY.'", //9
            "You walk through the open door into the Wizard's Tower. You see he has a shop   set-up with all kinds of magical items " +
            "like water breathing potions and fireball spell scrolls. You see the wizard at the counter near the end of the room.", //10
            "As you aproach the Ancient Ruins, you see a sign reading 'BEWARE OF SKELETONS'. You see that there is a door to the east. Head east if you want to enter", //11
            "As you approach the cave entrance you see a message in blood reading, 'VAMPIRE'S CAVE'. As you walk closer you " +
            "hear a girl screaming for help. Head south to go deeper into the cave", //12
            "You approach a farm that belongs to a small family. ", //13
            "You walk into the Stables and see many horses. Infront of each horse's pen is a sign that says the owner. " +
            "One sign says a horse is for sale for 15 silver. You  see some people feeding some of the horses.", //14
            "There is a sign infront of a path up the mountain that reads, 'Red Dragon's     Mountain'. " +
            "Head south if you want to climb the mountain.", //15
            "You Enter the secret code and are granted acess to a bowling alley. As you walk in you see it is all light up by dark red candles" +
            " You see alot of pretty women walking around. A man approaches you and adk if you would like to bowl a game or two." //16
        };
        static public string[] mapMessageVamp = new string[]
        {
            "You are at the bottom of the ocean, in the sunken ship, The Titanic. You see    some sharks around you but they " +
            "ignore you. In side the ship you see what might  be a chest", //0
            "The Orcs throw the boxes at you. With your enhanced vampiric reflexes you dodge all of the boxes they can throw at you.", //1
            "You walk into the Monestary where the monks see you. They stop their meditation to drench you in Holy Water. You disinagrate into a puddle.", //2
            "There is a fog so it is hard to see. But you walk into a graveyard where you can make out a tombstone in the shape of '#1'. It reads 'RIP Smithy Werbenman      Jensen'. You also see a spoopy ghost.", //3
            "When you walk into the tavern you see they are selling booze. 10 silver coins   each. ", //4
            "YOU ARE NOT ALLOWED IN", //7
            "The towns people see you and start to chase you with pitchforks and torches. '  BURN HIM' you hear from behind", //6
            "You walk into the forest and see Centaurs galloping away from you. They disapear into the forest.", //7
            "The Guards see you attempting to enter the Castle and kill you with their    emergency holy water.", //8
            "The Guards see you attempting to enter the Knight's Armory and kill you with their    emergency holy water.", //9
            "You walk throught the open door into the Wizard's Tower. You see he has a shop set-up with all kinds of magical items " +
            "like water breathing potions and fireball spell scrolls. You see the wizard at the counter near the end of the room.", //10
            "As you aproach the Ancient Ruins, you see a sign reading 'BEWARE OF SKELETONS'. You see that there is a door to the east. Head east if you want to enter", //11
            "As you approach the cave entrance you see a message in blood reading, 'VAMPIRE'S CAVE'.", //12
            "The farmer comes out with a metal bar like thing. He shouts 'PROTECT ME GUN' and then a metal ball comes out of it " +
            "at immense speeds. 'Take all my marijuana,  just don't kill me.", //13
            "The horse kicks you in the face. You then get up and eat the horse.", //14
            "There is a sign infront of a path up the mountain that reads, 'Red Dragon's     Mountain'. " +
            "Head south if you want to climb the mountain.", //15
            "You Enter the secret code and are granted acess to a bowling alley. As you walk in you see it is all light up by dark red candles" +
            " You see alot of pretty women walking around. A man approaches you and ask if you would like to bowl a game or two." //16
        };
        static public string[] mapMessageDrunk = new string[]
        {
            "You are at the bottom of the ocean, in the sunken ship, The Tit-an-ic. You see    some sharks around you but they " +
            "ignore you. In side the ship you see what might  be a Giant pen-- squid, its a squid.", // 0
            "You see some weird blue humanoid creatures, you hear some shout, 'HI I'M MISTER MEESEEKS'. They are carrying some boxes off of the docked ships and heading south. You see some navy men heading " +
            "to the     south east. You see some others who look like they run the dock", // 1
            "You see some demons medatating. He looks a little thirsty.", // 2
            "There is a fog so it is hard to see. But you walk into a graveyard where you can make out a tombstone in the shape of '#1'. It reads 'RIP Smithy Werbenman      Jensen'. " +
            " You see as a bunch of fish skeletons rise from their graves", // 3
            "Someone shouts 'WHO DRANK THE LAST HEAT TAP.' Then the whole tavern burst into a brawl", //4
            "You walk in, yell, 'anyone want some CHOCOLATE'. A guy yells back ' CHOCOLATE?, CHOCOLATE?, CHOCOLATE!!", //7
            "You walk into a fountain.", //6
            "In the forest you see some minitors getting drunk. They ask you to join in, and you do join.", //7
            "You want in and slap the king and queen.", //8
            "You see free armor so you take it.", //9
            "You walk in and drink ALL the potions you see. You feel so hyper that you go outside, and climb up the wizard tower " +
            "You then see a pile of hay so you jump into it. You die.", //10
            "You see a marvelous castle. You can head east to head into the castle.", //11
            "You see a cave that has a sign reading 'Free candy and fresh booze'. Head south to go into the cave.", //12
            "You walk into a marijuana field.", //13
            "You see a bunch of asinine centarues, donkey men. they all pull out bongos and start playing them. They are start " +
            "a pray to Old Lady Big Rock Mountain.", //14
            "There is a mountain made of delicious candy, there is a sign reading 'Reward is a dragon'. head south to clim the mountain to get " +
            "your reward. ", //17
            "You Enter the secret code and are granted acess to a bowling alley. As you walk in you see it is all light up by dark red candles" +
            " You see alot of pretty women walking around. A man approaches you and ask if you would like to bowl a game or two." //16
        };
        static public string[] mapMessageDrunkVamp = new string[]
        {
            "You are at the bottom of the ocean, in the sunken ship, The Tit-an-ic. You see    some sharks around you but they " +
            "ignor you. In side the ship you see what might  be a Giant pen-- squid, its a squid.", // 0
            "You see some wierd blue huminoid creatures, you hear some shout, 'HI I'M MISTER MEESEEKS'. They start to throw the boxes at you.", // 1
            "You see some demons medatating. One of them gets up and drenches you with Holy water and you die.", // 2
            "There is a fog so it is hard to see. But you walk into a graveyard where you can make out a tombstone in the shape of '#1'. It reads 'RIP Smithy Werbenman      Jensen'. " +
            " You see as a bunch of fish skeletons rise from their graves", // 3
            "Someone shouts 'WHO DRANK THE LAST HEAT TAP.' Then the whole tavern burst into a brawl", //4
            "You walk in, yell, 'anyone want some BLOOD'. A guy yells back ' BLOOD?, BLOOD?, BLOOD!!", //7
            "You walk into a fountain. You look up and everyone looks like zombies, and they have glowing blue eyes?", //6
            "In the forest you see some minitors getting drunk. They run way from you.", //7
            "You want in and slap the king and queen. You then get stabbed by a knight.", //8
            "You see free armor so you take it.", //9
            "You walk in and drink ALL the potions you see. You feel so hyper that you go outside, and climb up the wizard tower " +
            "You then see a pile of hay so you jump into it. Your fine.", //10
            "You see a marvelous castle. You can head east to head into the castle.", //11
            "You see a cave that has a sign reading 'Free blood and booze'. Head south to go into the cave.", //12
            "The farmer comes out with a metal bar like thing. He shouts 'PROTECT ME GUN' and then a metal ball comes out of it " +
            "at immens speeds. 'Take all my marijuana, just don't kill me.", //13
            "You see a bunch of asinine centarues, donkey men. They all start insulting you. You start to feel weak.", //14
            "There is a mountain made of delicious candy, there is a sign reading 'Reward is a dragon'. head south to clim the mountain to get " +
            "your reward. ", //17
            "You Enter the secret code and are granted acess to a bowling alley. " +
            " You see alot of pretty women walking around. You think to your self 'Bitches Love Cannons'" //16
        };
        static public bool vampiresDead = false;
        static public string[] vampVampireCaveMsg = new string[]
        {
            "The vampires agree to let you live there. The only other option is to live alone in the forest.",
            "You walk in and see the mess of the other vampires you made earlier"
        };

        // 0 is red, 1 is blue, 2 is brown, 3 is white, 4 is yellow, 5 is grey, 6 is darkred, 7 black, 8 darkcayn, 9 dark magenta, a/11 is dark blue, b/12 is dark gray, c/13 Dark green, d/14 Green
        static public int[,,] mapImg = new int[,,]
        {
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 3, 3, 3, 2, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 1, 3, 2, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 3, 1, 3, 3, 3, 3, 3, 1, 1, 3, 3, 3, 2, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 4, 4, 4, 4, 4, 4, 4, 4, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 1, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 2, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 2, 2, 2, 1, 2, 2, 2, 2, 2, 1, 1, 1, 1, 2, 2, 2, 4, 4, 4, 4, 4, 4, 4, 4, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 3, 3, 3, 3, 3, 1, 1, 1, 3, 3, 3, 1, 2, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 4, 4, 4, 4, 4, 4, 4, 2, 2, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 2, 3, 3, 2, 2, 2, 3, 3, 2, 3, 3, 2, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 1, 2, 2, 1, 1, 1, 1, 2, 2, 2, 2, 4, 4, 4, 4, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 2, 4, 4, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 3, 1, 3, 3, 3, 3, 3, 1, 3, 3, 3, 2, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 1, 3, 2, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 3, 1, 3, 2, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //0 
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //1
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 3, 7, 3, 7, 7, 7, 7, 7, 7, 7, 4, 4, 4, 4, 4, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 3, 7, 3, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 4, 4, 4, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //2
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 0},
                {0, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 5, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 0},
                {0, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 5, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 0},
                {0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 0},
                {0, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 0},
                {0, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 2, 2, 2, 5, 2, 2, 5, 2, 2, 0},
                {0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //3
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 6, 7, 7, 6, 6, 6, 6, 6, 6, 6, 7, 7, 6, 7, 7, 7, 7, 7, 7, 6, 7, 7, 6, 6, 6, 6, 6, 6, 6, 7, 7, 6, 7, 7, 7, 7, 7, 7, 6, 7, 7, 6, 6, 6, 6, 6, 6, 6, 7, 7, 6, 7, 7, 7, 7, 7, 0},
                {0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 6, 7, 7, 7, 7, 7, 0},
                {0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 6, 6, 6, 7, 7, 7, 6, 7, 7, 7, 6, 6, 6, 7, 7, 7, 7, 7, 7, 6, 6, 6, 7, 7, 7, 6, 7, 7, 7, 6, 6, 6, 7, 7, 7, 7, 7, 7, 6, 6, 6, 7, 7, 7, 6, 7, 7, 7, 6, 6, 6, 7, 7, 7, 7, 7, 0},
                {0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 6, 7, 6, 7, 7, 6, 7, 6, 7, 7, 6, 7, 6, 7, 7, 7, 7, 7, 7, 6, 7, 6, 7, 7, 6, 7, 6, 7, 7, 6, 7, 6, 7, 7, 7, 7, 7, 7, 6, 7, 6, 7, 7, 6, 7, 6, 7, 7, 6, 7, 6, 7, 7, 7, 7, 7, 0},
                {0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 6, 7, 6, 7, 6, 7, 7, 7, 6, 7, 6, 7, 6, 7, 7, 7, 7, 7, 7, 6, 7, 6, 7, 6, 7, 7, 7, 6, 7, 6, 7, 6, 7, 7, 7, 7, 7, 7, 6, 7, 6, 7, 6, 7, 7, 7, 6, 7, 6, 7, 6, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //4
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 1, 1, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 6, 6, 9, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 1, 1, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 6, 6, 9, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 1, 1, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 6, 6, 9, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 8, 8, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 1, 1, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 6, 6, 9, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 7, 7, 0},
                {0, 7, 7, 2, 8, 8, 8, 7, 7, 7, 7, 7, 7, 7, 7, 3, 1, 1, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 7, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 7, 8, 8, 8, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 6, 6, 9, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 2, 7, 7, 0},
                {0, 7, 7, 2, 7, 7, 7, 8, 8, 7, 7, 7, 7, 7, 7, 3, 1, 1, 3, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 8, 8, 7, 7, 7, 7, 7, 7, 7, 7, 9, 6, 6, 9, 7, 7, 7, 7, 7, 7, 8, 8, 7, 7, 7, 2, 7, 7, 0},
                {0, 7, 7, 2, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 7, 7, 7, 9, 9, 9, 9, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 2, 7, 7, 0},
                {0, 7, 7, 2, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 7, 7, 7, 7, 7, 2, 7, 7, 0},
                {0, 7, 7, 2, 2, 2, 2, 2, 2, 2, 7, 7, 7, 7, 7, 7, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 2, 2, 2, 2, 2, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 2, 2, 2, 2, 2, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 4, 4, 7, 7, 7, 7, 7, 7, 2, 2, 2, 2, 2, 2, 2, 7, 7, 0},
                {0, 7, 7, 2, 2, 2, 2, 2, 2, 2, 7, 7, 7, 7, 7, 7, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 2, 2, 2, 2, 2, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 2, 2, 2, 2, 2, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 4, 4, 7, 7, 7, 7, 7, 7, 2, 2, 2, 2, 2, 2, 2, 7, 7, 0},
                {0, 7, 7, 2, 2, 2, 2, 2, 2, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 2, 2, 2, 2, 2, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 2, 2, 2, 2, 2, 2, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 2, 2, 2, 2, 2, 2, 2, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //5
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 0},
                {0, 11, 4, 11, 11, 11, 11, 4, 11, 11, 9, 11, 11, 11, 11, 0, 9, 11, 11, 0, 11, 9, 11, 11, 0, 11, 0, 9, 4, 4, 9, 9, 11, 11, 11, 11, 11, 1, 1, 11, 11, 1, 1, 11, 11, 11, 11, 11, 4, 9, 9, 11, 4, 11, 11, 11, 11, 11, 0, 11, 11, 11, 11, 11, 11, 0, 11, 11, 11, 11, 0, 11, 4, 11, 11, 11, 11, 4, 11, 0},
                {0, 11, 11, 7, 7, 7, 7, 11, 11, 4, 11, 11, 0, 11, 9, 11, 11, 4, 11, 11, 11, 4, 11, 4, 11, 11, 9, 9, 0, 11, 4, 11, 9, 11, 4, 11, 1, 11, 11, 1, 1, 5, 11, 1, 11, 0, 11, 11, 11, 11, 4, 9, 11, 11, 9, 4, 0, 0, 11, 11, 0, 11, 0, 0, 11, 11, 9, 0, 11, 9, 11, 11, 11, 7, 7, 7, 7, 11, 11, 0},
                {0, 11, 0, 7, 4, 4, 7, 11, 9, 11, 9, 11, 9, 11, 9, 11, 9, 11, 11, 9, 11, 11, 11, 11, 11, 11, 9, 11, 11, 11, 11, 11, 11, 11, 11, 1, 11, 1, 5, 5, 1, 5, 1, 11, 1, 11, 11, 11, 11, 11, 4, 11, 11, 11, 4, 11, 11, 11, 11, 11, 9, 11, 9, 4, 11, 9, 11, 11, 11, 11, 0, 11, 9, 7, 4, 4, 7, 11, 11, 0},
                {0, 9, 11, 7, 4, 4, 7, 11, 0, 11, 9, 9, 0, 4, 0, 9, 11, 11, 4, 9, 0, 11, 9, 11, 11, 11, 11, 11, 11, 11, 11, 11, 0, 4, 11, 11, 1, 11, 5, 1, 5, 5, 11, 1, 4, 4, 11, 11, 11, 11, 11, 11, 9, 11, 11, 11, 9, 11, 0, 11, 11, 11, 0, 4, 0, 11, 11, 4, 0, 9, 9, 9, 11, 7, 4, 4, 7, 11, 11, 0},
                {0, 11, 11, 7, 7, 7, 7, 11, 11, 9, 11, 11, 0, 9, 0, 4, 4, 11, 0, 4, 11, 0, 11, 11, 11, 0, 11, 11, 11, 11, 11, 11, 4, 9, 4, 1, 1, 11, 5, 5, 1, 5, 11, 1, 1, 11, 11, 4, 4, 11, 9, 11, 11, 9, 11, 4, 9, 11, 11, 11, 11, 0, 0, 11, 9, 11, 11, 9, 11, 9, 4, 11, 11, 7, 7, 7, 7, 11, 11, 0},
                {0, 11, 4, 11, 7, 7, 11, 4, 11, 11, 9, 9, 11, 11, 11, 11, 9, 11, 9, 9, 4, 11, 11, 4, 0, 0, 11, 11, 11, 11, 11, 9, 0, 0, 1, 1, 5, 5, 5, 1, 5, 5, 5, 5, 1, 1, 11, 11, 0, 11, 11, 11, 11, 11, 4, 9, 11, 11, 11, 0, 9, 9, 9, 9, 9, 11, 0, 0, 0, 9, 11, 11, 4, 11, 7, 7, 11, 4, 11, 0},
                {0, 9, 11, 11, 7, 7, 11, 11, 11, 11, 11, 11, 9, 11, 9, 11, 11, 11, 11, 4, 0, 0, 9, 9, 11, 4, 11, 11, 11, 11, 11, 0, 9, 1, 1, 5, 5, 12, 1, 12, 1, 12, 5, 5, 5, 1, 1, 0, 4, 11, 11, 11, 11, 9, 4, 4, 9, 11, 11, 0, 4, 11, 0, 0, 0, 11, 9, 9, 9, 0, 9, 11, 11, 11, 7, 7, 11, 11, 11, 0},
                {0, 11, 9, 9, 7, 7, 11, 11, 11, 11, 4, 11, 11, 4, 11, 11, 11, 11, 11, 9, 0, 4, 11, 11, 11, 0, 4, 0, 0, 11, 0, 0, 1, 1, 5, 5, 12, 1, 12, 1, 12, 1, 12, 5, 5, 5, 1, 1, 11, 11, 11, 11, 4, 11, 11, 11, 11, 11, 4, 0, 11, 0, 11, 11, 11, 0, 4, 0, 0, 0, 0, 0, 11, 11, 7, 7, 11, 11, 11, 0},
                {0, 9, 11, 11, 7, 7, 9, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 4, 11, 0, 11, 4, 11, 9, 11, 9, 9, 9, 0, 12, 1, 5, 5, 12, 1, 12, 12, 1, 12, 12, 1, 12, 5, 5, 5, 1, 12, 11, 4, 4, 11, 11, 11, 11, 11, 11, 9, 11, 11, 11, 11, 0, 0, 4, 4, 0, 11, 11, 11, 0, 11, 11, 7, 7, 11, 11, 11, 0},
                {0, 11, 4, 9, 7, 7, 11, 11, 11, 11, 9, 11, 0, 11, 11, 11, 9, 11, 9, 11, 0, 0, 11, 0, 0, 0, 11, 9, 4, 0, 4, 12, 5, 5, 12, 1, 12, 12, 12, 1, 12, 12, 12, 1, 12, 5, 5, 5, 12, 11, 11, 11, 11, 11, 11, 11, 0, 11, 11, 11, 11, 11, 9, 11, 11, 11, 0, 0, 11, 4, 4, 11, 4, 0, 7, 7, 11, 11, 11, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 4, 7, 7, 7, 7, 7, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //6
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 13, 13, 13, 13, 14, 13, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 13, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 14, 13, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 13, 14, 13, 13, 13, 13, 13, 14, 13, 14, 14, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 13, 14, 13, 13, 14, 14, 13, 13, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 13, 14, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 14, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 13, 14, 13, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 14, 13, 14, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 14, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 14, 13, 14, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 14, 13, 13, 13, 13, 13, 14, 14, 14, 14, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 13, 14, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 13, 0},
                {0, 13, 13, 14, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 14, 13, 13, 14, 14, 14, 14, 14, 0, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 14, 13, 14, 13, 13, 13, 13, 13, 14, 14, 14, 0, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 14, 13, 14, 14, 14, 13, 13, 13, 13, 13, 13, 14, 14, 14, 0, 14, 13, 0},
                {0, 13, 14, 14, 0, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 0, 14, 14, 14, 14, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 0, 14, 14, 14, 14, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 0, 14, 14, 14, 14, 0},
                {0, 14, 0, 14, 14, 14, 0, 14, 13, 13, 13, 14, 14, 13, 13, 13, 14, 14, 14, 14, 14, 0, 14, 14, 0, 14, 14, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 14, 14, 13, 13, 13, 14, 0, 14, 14, 0, 14, 14, 0, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 13, 13, 13, 13, 13, 14, 14, 14, 14, 14, 0, 14, 0},
                {0, 14, 14, 14, 14, 14, 14, 14, 14, 13, 14, 14, 14, 14, 13, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 13, 13, 14, 14, 14, 14, 14, 14, 13, 13, 14, 14, 14, 14, 14, 13, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 13, 13, 13, 13, 14, 14, 14, 14, 14, 14, 13, 13, 13, 13, 14, 14, 14, 14, 14, 14, 14, 14, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //7
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 7, 7, 3, 3, 3, 3, 3, 7, 7, 4, 0, 0, 4, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 4, 0, 0, 4, 7, 7, 3, 3, 3, 3, 3, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 4, 7, 7, 7, 7, 7, 7, 4, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 4, 4, 7, 7, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 4, 4, 7, 7, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 4, 4, 4, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 4, 7, 7, 7, 7, 7, 7, 4, 7, 7, 7, 7, 7, 7, 7, 4, 4, 4, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 4, 4, 4, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 4, 4, 4, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 0, 0, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 4, 4, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 4, 4, 4, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 4, 4, 4, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 4, 4, 4, 4, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 4, 4, 4, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 4, 4, 4, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 4, 4, 4, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 4, 4, 4, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 4, 4, 4, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 4, 4, 4, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //8
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 5, 5, 5, 12, 5, 5, 5, 5, 5, 5, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 4, 5, 5, 5, 5, 5, 5, 12, 5, 5, 5, 0},
                {0, 5, 5, 12, 12, 12, 5, 5, 5, 5, 5, 11, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 9, 9, 9, 9, 9, 9, 9, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 9, 9, 9, 9, 9, 9, 9, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 11, 5, 5, 5, 5, 5, 12, 12, 12, 5, 5, 0},
                {0, 5, 12, 5, 7, 5, 12, 5, 5, 5, 5, 11, 5, 5, 5, 5, 5, 5, 12, 12, 12, 12, 12, 5, 5, 5, 5, 9, 11, 11, 4, 11, 11, 9, 5, 5, 5, 12, 12, 1, 1, 12, 12, 5, 5, 5, 9, 11, 11, 4, 11, 11, 9, 5, 5, 5, 5, 12, 12, 12, 12, 12, 5, 5, 5, 5, 5, 5, 11, 5, 5, 5, 5, 12, 5, 7, 5, 12, 5, 0},
                {0, 5, 12, 7, 5, 7, 12, 5, 5, 5, 11, 4, 11, 5, 5, 5, 5, 12, 6, 6, 4, 6, 6, 12, 5, 5, 5, 9, 11, 4, 11, 4, 11, 9, 5, 5, 5, 12, 1, 1, 1, 1, 12, 5, 5, 5, 9, 11, 4, 11, 4, 11, 9, 5, 5, 5, 12, 6, 6, 4, 6, 6, 12, 5, 5, 5, 5, 11, 4, 11, 5, 5, 5, 12, 7, 5, 7, 12, 5, 0},
                {0, 5, 5, 12, 7, 12, 5, 5, 5, 11, 5, 12, 5, 11, 5, 5, 12, 6, 6, 4, 6, 4, 6, 6, 12, 5, 5, 9, 4, 11, 11, 11, 4, 9, 5, 5, 5, 12, 1, 12, 12, 1, 12, 5, 5, 5, 9, 4, 11, 11, 11, 4, 9, 5, 5, 12, 6, 6, 4, 6, 4, 6, 6, 12, 5, 5, 11, 5, 12, 5, 11, 5, 5, 5, 12, 7, 12, 5, 5, 0},
                {0, 5, 12, 5, 12, 5, 12, 5, 5, 5, 5, 12, 5, 5, 5, 5, 12, 4, 4, 11, 4, 11, 4, 4, 12, 5, 5, 9, 11, 4, 11, 4, 11, 9, 5, 5, 5, 5, 1, 5, 5, 1, 5, 5, 5, 5, 9, 11, 4, 11, 4, 11, 9, 5, 5, 12, 4, 4, 11, 4, 11, 4, 4, 12, 5, 5, 5, 5, 12, 5, 5, 5, 5, 12, 5, 12, 5, 12, 5, 0},
                {0, 12, 7, 12, 12, 12, 7, 12, 5, 5, 5, 12, 5, 5, 5, 5, 12, 6, 4, 11, 4, 11, 4, 6, 12, 5, 5, 9, 11, 11, 4, 11, 11, 9, 5, 5, 5, 5, 1, 5, 5, 1, 5, 5, 5, 5, 9, 11, 11, 4, 11, 11, 9, 5, 5, 12, 6, 4, 11, 4, 11, 4, 6, 12, 5, 5, 5, 5, 12, 5, 5, 5, 12, 7, 12, 12, 12, 7, 12, 0},
                {0, 12, 7, 12, 5, 12, 7, 12, 5, 5, 5, 12, 5, 5, 5, 5, 12, 6, 4, 11, 4, 11, 4, 6, 12, 5, 5, 9, 11, 4, 11, 4, 11, 9, 5, 5, 5, 5, 1, 5, 5, 1, 5, 5, 5, 5, 9, 11, 4, 11, 4, 11, 9, 5, 5, 12, 6, 4, 11, 4, 11, 4, 6, 12, 5, 5, 5, 5, 12, 5, 5, 5, 12, 7, 12, 5, 12, 7, 12, 0},
                {0, 12, 12, 5, 12, 5, 12, 12, 5, 5, 5, 12, 5, 5, 5, 5, 5, 12, 6, 11, 4, 11, 6, 12, 5, 5, 5, 9, 4, 4, 11, 4, 4, 9, 5, 5, 5, 5, 1, 5, 5, 1, 5, 5, 5, 5, 9, 4, 4, 11, 4, 4, 9, 5, 5, 5, 12, 6, 11, 4, 11, 6, 12, 5, 5, 5, 5, 5, 12, 5, 5, 5, 12, 12, 5, 12, 5, 12, 5, 0},
                {0, 12, 5, 12, 5, 12, 5, 12, 5, 5, 5, 12, 5, 5, 5, 5, 5, 5, 12, 11, 4, 11, 12, 5, 5, 5, 5, 9, 11, 4, 11, 4, 11, 9, 5, 5, 12, 1, 1, 1, 1, 1, 1, 12, 5, 5, 9, 11, 4, 11, 4, 11, 9, 5, 5, 5, 5, 12, 11, 4, 11, 12, 5, 5, 5, 5, 5, 5, 12, 5, 5, 5, 12, 5, 12, 5, 12, 5, 12, 0},
                {0, 5, 12, 5, 12, 5, 12, 5, 5, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 12, 12, 12, 5, 5, 5, 5, 5, 9, 11, 9, 4, 9, 11, 9, 5, 5, 12, 1, 1, 1, 1, 1, 1, 12, 5, 5, 9, 11, 9, 4, 9, 11, 9, 5, 5, 5, 5, 5, 12, 12, 12, 5, 5, 5, 5, 5, 5, 5, 12, 5, 5, 5, 5, 12, 5, 12, 5, 12, 5, 0},
                {0, 5, 5, 12, 5, 12, 5, 5, 5, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 9, 11, 9, 11, 9, 5, 5, 5, 12, 12, 12, 12, 12, 12, 12, 12, 5, 5, 5, 9, 11, 9, 11, 9, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 5, 5, 5, 5, 5, 12, 5, 12, 5, 5, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //9
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 12, 12, 12, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 9, 9, 9, 9, 7, 7, 7, 12, 12, 7, 7, 7, 7, 7, 9, 9, 9, 9, 9, 7, 7, 7, 7, 7, 7, 12, 12, 7, 7, 7, 9, 9, 9, 9, 9, 7, 7, 7, 7, 7, 7, 7, 9, 9, 9, 9, 9, 7, 7, 7, 12, 12, 12, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 12, 12, 12, 12, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 9, 4, 4, 4, 9, 7, 7, 7, 12, 12, 12, 7, 7, 7, 7, 9, 4, 4, 4, 9, 7, 7, 7, 7, 7, 12, 12, 12, 7, 7, 7, 9, 4, 4, 4, 9, 7, 7, 7, 7, 7, 7, 7, 9, 4, 4, 5, 5, 7, 7, 12, 12, 12, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 12, 12, 12, 12, 7, 7, 7, 7, 7, 3, 14, 3, 7, 3, 4, 3, 7, 9, 4, 4, 4, 9, 7, 7, 7, 7, 12, 12, 12, 7, 7, 7, 9, 4, 4, 4, 9, 7, 7, 7, 7, 12, 12, 12, 7, 7, 7, 7, 9, 4, 4, 4, 9, 7, 7, 7, 7, 7, 7, 7, 9, 4, 5, 5, 9, 3, 12, 3, 3, 12, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 12, 3, 3, 3, 12, 7, 7, 7, 7, 7, 3, 3, 3, 7, 3, 3, 3, 7, 9, 4, 4, 4, 9, 7, 7, 7, 12, 3, 3, 3, 12, 7, 7, 9, 4, 4, 4, 9, 7, 7, 7, 12, 3, 3, 3, 12, 7, 7, 7, 9, 4, 4, 4, 9, 7, 7, 7, 7, 12, 7, 7, 9, 4, 5, 4, 12, 7, 3, 7, 3, 12, 12, 7, 0},
                {0, 7, 7, 7, 7, 12, 3, 3, 3, 3, 3, 12, 7, 7, 7, 7, 12, 12, 12, 12, 12, 12, 12, 12, 9, 4, 4, 4, 9, 7, 7, 7, 5, 7, 3, 7, 7, 7, 7, 9, 4, 4, 4, 9, 3, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 9, 4, 4, 4, 9, 7, 7, 7, 12, 12, 7, 7, 9, 4, 5, 4, 12, 12, 7, 3, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 9, 4, 4, 4, 9, 7, 7, 7, 5, 7, 3, 3, 7, 7, 7, 9, 4, 4, 4, 3, 2, 3, 7, 7, 3, 3, 7, 5, 7, 7, 7, 9, 4, 4, 4, 9, 7, 7, 7, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 7, 7, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 7, 7, 3, 1, 3, 7, 3, 0, 3, 7, 9, 4, 4, 4, 9, 7, 7, 7, 5, 7, 3, 7, 3, 7, 7, 9, 4, 4, 4, 3, 3, 3, 7, 3, 7, 3, 7, 5, 7, 7, 7, 9, 4, 4, 4, 9, 7, 7, 7, 12, 7, 12, 12, 12, 12, 12, 12, 9, 12, 7, 7, 3, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 3, 7, 3, 7, 3, 7, 7, 7, 7, 7, 3, 3, 3, 7, 3, 3, 3, 7, 9, 4, 4, 4, 9, 7, 7, 7, 5, 7, 3, 7, 7, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7, 7, 3, 7, 5, 7, 7, 7, 9, 4, 4, 4, 9, 7, 7, 12, 12, 7, 12, 12, 12, 12, 12, 12, 9, 12, 12, 7, 3, 7, 7, 7, 0},
                {0, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 7, 9, 4, 4, 4, 9, 7, 7, 7, 5, 7, 3, 3, 7, 7, 7, 9, 4, 5, 5, 5, 7, 7, 7, 7, 3, 3, 7, 5, 7, 7, 7, 9, 4, 4, 4, 9, 7, 7, 12, 7, 7, 12, 12, 12, 12, 12, 12, 9, 7, 12, 7, 3, 7, 7, 7, 0},
                {0, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 7, 9, 4, 4, 4, 9, 7, 7, 7, 5, 5, 5, 5, 3, 7, 7, 9, 4, 5, 5, 5, 7, 7, 7, 3, 5, 5, 5, 5, 7, 7, 7, 9, 4, 4, 4, 9, 7, 7, 12, 7, 7, 7, 12, 12, 12, 12, 4, 9, 7, 12, 3, 7, 3, 7, 7, 0},
                {0, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 7, 9, 9, 9, 9, 9, 7, 7, 7, 5, 7, 7, 5, 3, 7, 7, 9, 9, 5, 5, 5, 7, 7, 7, 3, 5, 7, 7, 5, 7, 7, 7, 9, 9, 9, 9, 9, 7, 7, 12, 7, 7, 7, 7, 4, 6, 0, 9, 9, 7, 12, 3, 7, 3, 7, 7, 0},
                {0, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 7, 7, 7, 7, 7, 7, 7, 7, 7, 5, 7, 7, 5, 7, 7, 7, 7, 5, 5, 7, 5, 5, 7, 7, 7, 5, 7, 7, 5, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 12, 7, 7, 7, 6, 0, 4, 6, 7, 7, 7, 12, 3, 7, 3, 7, 7, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //10
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 13, 5, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 14, 5, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 12, 5, 5, 13, 5, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 14, 13, 14, 5, 5, 13, 13, 13, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 5, 12, 13, 14, 5, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 14, 5, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 5, 5, 14, 5, 5, 12, 5, 13, 13, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 12, 5, 13, 14, 14, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 13, 14, 5, 5, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 14, 5, 14, 5, 12, 13, 5, 13, 13, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 13, 12, 5, 5, 5, 5, 13, 13, 13, 13, 13, 13, 13, 13, 5, 14, 5, 5, 5, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 12, 5, 12, 13, 13, 13, 13, 13, 13, 13, 13, 5, 13, 14, 13, 13, 13, 13, 13, 13, 13, 5, 12, 5, 14, 5, 12, 5, 14, 5, 5, 13, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 5, 14, 5, 12, 5, 13, 5, 5, 13, 13, 13, 13, 13, 13, 13, 5, 12, 14, 5, 5, 13, 13, 13, 13, 13, 13, 13, 13, 13, 12, 13, 14, 5, 12, 13, 13, 13, 13, 13, 13, 13, 13, 12, 5, 5, 13, 13, 13, 13, 13, 5, 5, 5, 12, 5, 5, 5, 12, 5, 5, 5, 5, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 5, 5, 5, 5, 5, 14, 14, 13, 5, 13, 13, 13, 13, 13, 13, 13, 5, 14, 12, 5, 5, 13, 13, 13, 13, 13, 13, 13, 13, 12, 5, 14, 5, 14, 5, 12, 13, 13, 13, 13, 13, 13, 14, 13, 13, 5, 13, 13, 13, 13, 5, 5, 14, 12, 5, 5, 5, 12, 5, 14, 5, 5, 5, 13, 13, 13, 13, 13, 0},
                {0, 13, 13, 13, 13, 13, 13, 13, 13, 13, 5, 5, 14, 12, 14, 5, 5, 14, 14, 5, 13, 13, 13, 13, 13, 13, 13, 5, 12, 5, 14, 5, 13, 13, 13, 13, 13, 13, 5, 12, 5, 5, 5, 5, 13, 5, 14, 12, 13, 13, 13, 13, 13, 13, 12, 12, 14, 13, 13, 13, 13, 5, 14, 13, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 13, 13, 13, 13, 0},
                {0, 13, 13, 0, 14, 14, 14, 13, 5, 5, 5, 14, 12, 5, 5, 13, 5, 5, 5, 14, 5, 13, 0, 14, 14, 13, 13, 5, 5, 12, 5, 14, 13, 13, 13, 13, 14, 5, 12, 13, 14, 5, 13, 5, 14, 13, 13, 14, 12, 13, 13, 13, 13, 5, 5, 14, 12, 13, 13, 13, 5, 5, 13, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 14, 14, 13, 13, 0},
                {0, 14, 14, 14, 14, 0, 14, 14, 5, 13, 14, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 14, 14, 0, 14, 14, 13, 5, 12, 13, 14, 5, 13, 13, 13, 14, 13, 12, 13, 14, 5, 13, 5, 13, 5, 5, 13, 14, 13, 12, 13, 13, 13, 5, 14, 13, 5, 13, 13, 13, 5, 5, 5, 5, 14, 5, 5, 5, 5, 5, 5, 5, 5, 5, 14, 14, 5, 13, 13, 0},
                {0, 14, 14, 0, 14, 14, 14, 0, 5, 5, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 0, 14, 14, 14, 0, 5, 5, 5, 12, 5, 14, 5, 13, 14, 5, 5, 5, 12, 5, 13, 5, 5, 5, 5, 13, 13, 5, 14, 13, 12, 13, 5, 14, 13, 5, 5, 5, 13, 13, 5, 5, 5, 5, 13, 5, 5, 5, 5, 14, 5, 5, 5, 14, 14, 13, 5, 13, 13, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //11
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 12, 12, 12, 12, 11, 11, 11, 11, 11, 11, 11, 12, 5, 5, 5, 5, 14, 14, 5, 5, 5, 5, 5, 5, 14, 14, 14, 5, 12, 11, 11, 11, 11, 11, 11, 11, 11, 12, 12, 12, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 12, 11, 11, 11, 11, 11, 11, 11, 11, 0},
                {0, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 12, 13, 13, 13, 13, 12, 11, 11, 11, 11, 11, 12, 5, 5, 5, 12, 12, 5, 14, 12, 12, 12, 12, 12, 12, 14, 14, 14, 5, 12, 12, 11, 11, 11, 11, 11, 11, 12, 13, 13, 13, 13, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 12, 13, 12, 11, 11, 11, 11, 11, 11, 11, 0},
                {0, 11, 11, 11, 11, 11, 11, 12, 12, 11, 11, 11, 11, 11, 12, 12, 13, 13, 13, 13, 13, 12, 11, 11, 11, 11, 11, 12, 14, 14, 12, 12, 12, 12, 14, 14, 14, 5, 5, 5, 5, 14, 12, 14, 5, 5, 12, 11, 11, 11, 11, 11, 12, 13, 13, 13, 13, 13, 13, 12, 11, 11, 11, 11, 11, 11, 11, 11, 12, 13, 13, 13, 12, 11, 11, 11, 11, 11, 11, 0},
                {0, 11, 11, 11, 11, 11, 12, 13, 13, 12, 11, 11, 11, 12, 13, 13, 13, 13, 13, 13, 13, 12, 11, 11, 11, 11, 12, 5, 5, 14, 12, 5, 5, 14, 14, 5, 14, 5, 14, 14, 5, 14, 5, 14, 14, 14, 12, 12, 11, 11, 11, 12, 13, 13, 13, 13, 13, 13, 13, 13, 12, 11, 11, 11, 11, 11, 11, 12, 13, 13, 13, 13, 13, 12, 11, 11, 11, 11, 11, 0},
                {0, 11, 11, 11, 11, 12, 13, 13, 13, 13, 12, 11, 12, 5, 5, 12, 12, 5, 5, 5, 5, 5, 12, 11, 11, 12, 5, 14, 14, 14, 5, 5, 14, 14, 5, 5, 14, 5, 5, 14, 14, 14, 5, 14, 12, 14, 14, 5, 12, 11, 12, 5, 5, 5, 5, 5, 5, 5, 12, 5, 12, 11, 11, 11, 11, 11, 12, 13, 13, 13, 13, 13, 13, 13, 12, 11, 11, 11, 11, 0},
                {0, 11, 11, 11, 12, 13, 13, 13, 13, 13, 12, 11, 12, 5, 12, 12, 5, 5, 5, 5, 5, 5, 12, 11, 11, 12, 5, 14, 5, 14, 14, 5, 5, 14, 5, 5, 7, 5, 5, 5, 14, 5, 5, 14, 14, 12, 14, 14, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 5, 12, 11, 11, 11, 12, 5, 5, 5, 5, 5, 12, 5, 5, 12, 11, 11, 11, 11, 0},
                {0, 11, 11, 12, 5, 5, 12, 5, 5, 5, 5, 12, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 12, 11, 12, 5, 14, 5, 12, 14, 5, 5, 14, 7, 7, 7, 7, 5, 5, 14, 14, 5, 5, 14, 12, 5, 14, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 5, 5, 12, 11, 12, 5, 5, 5, 5, 5, 5, 12, 12, 5, 5, 12, 11, 11, 11, 0},
                {0, 11, 12, 5, 5, 12, 12, 5, 5, 5, 12, 5, 5, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 12, 11, 12, 14, 14, 12, 5, 14, 5, 5, 7, 7, 7, 7, 7, 7, 5, 5, 14, 5, 5, 14, 12, 12, 14, 5, 12, 5, 5, 2, 2, 2, 2, 2, 5, 5, 12, 12, 5, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 5, 12, 11, 11, 11, 0},
                {0, 11, 12, 5, 12, 12, 5, 5, 5, 12, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 5, 14, 12, 12, 5, 14, 5, 5, 7, 7, 7, 7, 7, 7, 7, 5, 14, 14, 5, 14, 5, 12, 14, 5, 12, 5, 5, 2, 7, 2, 2, 2, 5, 5, 5, 12, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 5, 5, 12, 11, 11, 0},
                {0, 12, 5, 5, 12, 5, 5, 5, 12, 5, 5, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 14, 14, 12, 5, 14, 14, 5, 7, 7, 7, 7, 7, 7, 7, 7, 5, 5, 5, 5, 14, 5, 12, 5, 5, 5, 12, 5, 2, 2, 7, 7, 2, 5, 5, 5, 12, 12, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 5, 5, 12, 11, 0},
                {0, 5, 12, 12, 12, 5, 5, 12, 5, 12, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 14, 12, 5, 5, 14, 5, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 5, 5, 5, 5, 5, 12, 12, 5, 5, 5, 12, 2, 2, 2, 2, 2, 5, 5, 5, 5, 12, 12, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 5, 5, 12, 0},
                {0, 12, 12, 5, 5, 5, 12, 5, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 5, 12, 5, 5, 5, 5, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 5, 5, 5, 5, 5, 5, 12, 5, 5, 5, 12, 5, 5, 2, 5, 5, 5, 5, 5, 5, 5, 12, 12, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 5, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //12
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 11, 11, 11, 11, 12, 12, 12, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 0},
                {0, 11, 11, 11, 12, 5, 5, 5, 5, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 0},
                {0, 11, 11, 12, 5, 5, 5, 5, 5, 5, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 0},
                {0, 11, 12, 5, 5, 5, 12, 12, 5, 5, 5, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 12, 12, 5, 5, 5, 5, 12, 13, 13, 13, 13, 13, 13, 13, 12, 5, 5, 5, 5, 12, 0},
                {0, 12, 5, 5, 5, 5, 12, 12, 5, 5, 5, 5, 12, 12, 12, 12, 12, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 12, 5, 5, 5, 5, 5, 5, 12, 13, 13, 13, 13, 13, 13, 12, 5, 5, 5, 5, 5, 12, 0},
                {0, 13, 12, 5, 5, 5, 5, 5, 5, 5, 5, 12, 13, 13, 13, 13, 13, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 12, 5, 5, 5, 5, 5, 5, 5, 5, 12, 13, 13, 13, 13, 12, 5, 5, 5, 5, 5, 5, 5, 0},
                {0, 13, 12, 5, 5, 5, 5, 5, 5, 5, 5, 12, 13, 13, 13, 13, 13, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 13, 13, 12, 5, 5, 5, 5, 5, 5, 5, 5, 0},
                {0, 13, 12, 5, 5, 5, 12, 12, 5, 5, 5, 12, 13, 13, 13, 13, 13, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 13, 12, 5, 5, 5, 5, 5, 5, 5, 5, 0},
                {0, 13, 12, 5, 5, 5, 12, 12, 5, 5, 5, 12, 13, 13, 13, 13, 13, 12, 13, 13, 13, 4, 13, 13, 4, 13, 13, 4, 13, 13, 4, 13, 13, 4, 13, 13, 4, 13, 13, 4, 13, 13, 4, 13, 13, 4, 13, 13, 4, 13, 13, 4, 13, 13, 4, 5, 5, 4, 5, 5, 4, 5, 5, 4, 5, 5, 4, 5, 5, 4, 5, 5, 4, 5, 5, 4, 5, 5, 4, 0},
                {0, 13, 12, 5, 5, 5, 12, 12, 5, 5, 5, 12, 12, 12, 12, 12, 12, 12, 13, 13, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 5, 4, 4, 5, 4, 4, 5, 4, 4, 5, 4, 4, 5, 4, 4, 5, 4, 4, 5, 4, 4, 5, 4, 4, 5, 0},
                {0, 13, 12, 5, 5, 5, 12, 12, 5, 5, 5, 12, 13, 12, 13, 12, 13, 12, 13, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 13, 4, 4, 5, 4, 4, 5, 4, 4, 5, 4, 4, 5, 4, 4, 5, 4, 4, 5, 4, 4, 5, 4, 4, 5, 4, 5, 0},
                {0, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 13, 13, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //13
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 9, 4, 9, 6, 6, 6, 12, 6, 6, 3, 6, 3, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 6, 6, 6, 6, 6, 6, 6, 11, 6, 11, 6, 0},
                {0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 6, 6, 6, 6, 6, 6, 6, 6, 6, 4, 4, 9, 7, 9, 9, 6, 6, 12, 6, 6, 3, 11, 11, 11, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 6, 6, 6, 6, 6, 6, 9, 9, 9, 9, 6, 0},
                {0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 6, 6, 6, 6, 6, 6, 6, 6, 4, 4, 9, 9, 9, 9, 9, 6, 6, 12, 6, 6, 3, 7, 3, 11, 11, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 6, 6, 6, 6, 9, 9, 9, 11, 7, 11, 11, 0},
                {0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 6, 6, 6, 4, 4, 4, 4, 4, 4, 9, 9, 9, 9, 9, 9, 6, 6, 12, 6, 3, 3, 3, 3, 3, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 6, 6, 12, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 9, 9, 9, 9, 9, 11, 11, 11, 11, 11, 11, 0},
                {0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 6, 6, 4, 9, 9, 9, 9, 9, 9, 9, 9, 9, 6, 6, 6, 6, 6, 12, 6, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 11, 11, 11, 12, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 0},
                {0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 6, 4, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 6, 6, 6, 6, 6, 12, 6, 6, 6, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 6, 11, 12, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 6, 6, 0},
                {0, 7, 7, 5, 5, 5, 5, 5, 5, 5, 7, 7, 12, 7, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7, 7, 12, 7, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7, 7, 12, 7, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7, 7, 12, 7, 7, 5, 5, 5, 5, 5, 5, 5, 5, 7, 0},
                {0, 5, 5, 7, 7, 5, 5, 5, 7, 7, 5, 5, 12, 5, 5, 7, 7, 7, 5, 5, 5, 5, 5, 5, 5, 7, 7, 7, 5, 5, 12, 5, 5, 7, 7, 7, 7, 5, 5, 5, 5, 5, 5, 7, 7, 7, 7, 5, 5, 12, 5, 5, 7, 7, 7, 5, 5, 5, 5, 5, 5, 5, 7, 7, 7, 5, 5, 12, 5, 5, 7, 2, 2, 2, 2, 2, 7, 5, 5, 0},
                {0, 5, 5, 5, 5, 7, 7, 7, 5, 5, 5, 5, 12, 5, 5, 5, 5, 5, 7, 7, 7, 7, 7, 7, 7, 5, 5, 5, 5, 5, 12, 5, 5, 5, 5, 5, 5, 7, 7, 7, 7, 7, 7, 5, 5, 5, 5, 5, 5, 12, 5, 5, 5, 5, 5, 7, 7, 7, 7, 7, 7, 7, 5, 5, 5, 5, 5, 12, 5, 5, 5, 2, 7, 2, 2, 2, 5, 5, 5, 0},
                {0, 5, 5, 5, 7, 7, 7, 7, 7, 5, 5, 5, 12, 5, 5, 5, 5, 5, 7, 7, 7, 7, 7, 7, 7, 5, 5, 5, 5, 5, 12, 5, 5, 5, 5, 5, 5, 7, 7, 7, 7, 7, 7, 5, 5, 5, 5, 5, 5, 12, 5, 5, 5, 5, 5, 7, 7, 7, 7, 7, 7, 7, 5, 5, 5, 5, 5, 12, 5, 5, 5, 2, 2, 7, 7, 2, 5, 5, 5, 0},
                {0, 5, 7, 7, 5, 5, 5, 5, 5, 7, 7, 5, 12, 5, 5, 7, 7, 7, 5, 5, 5, 5, 5, 5, 5, 7, 7, 7, 5, 5, 12, 5, 5, 7, 7, 7, 7, 5, 5, 5, 5, 5, 5, 7, 7, 7, 7, 5, 5, 12, 5, 5, 7, 7, 7, 5, 5, 5, 5, 5, 5, 5, 7, 7, 7, 5, 5, 12, 5, 7, 7, 2, 2, 2, 2, 2, 7, 7, 5, 0},
                {0, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7, 12, 7, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7, 7, 12, 7, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7, 7, 12, 7, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7, 7, 12, 7, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //14
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 11, 11, 3, 11, 11, 12, 13, 13, 12, 11, 11, 3, 11, 11, 11, 11, 11, 12, 12, 11, 11, 11, 12, 5, 5, 14, 5, 14, 5, 12, 12, 5, 14, 14, 5, 5, 14, 14, 5, 5, 5, 5, 5, 5, 14, 14, 14, 5, 5, 5, 5, 5, 12, 12, 5, 14, 5, 5, 5, 14, 12, 12, 11, 3, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 0},
                {0, 3, 11, 11, 11, 12, 13, 13, 13, 13, 12, 11, 11, 11, 11, 11, 12, 12, 13, 13, 12, 3, 11, 12, 12, 5, 14, 14, 5, 5, 12, 14, 12, 5, 14, 5, 14, 14, 5, 5, 5, 14, 5, 5, 14, 5, 5, 14, 14, 5, 14, 5, 5, 12, 12, 5, 5, 14, 14, 14, 5, 5, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 12, 0},
                {0, 11, 11, 11, 12, 13, 13, 13, 13, 13, 12, 11, 11, 3, 11, 12, 12, 13, 13, 13, 12, 11, 11, 12, 12, 14, 5, 5, 14, 14, 5, 12, 14, 14, 14, 14, 5, 5, 5, 5, 5, 5, 14, 14, 14, 5, 14, 5, 14, 14, 5, 5, 5, 5, 12, 14, 14, 14, 5, 5, 14, 5, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 3, 11, 11, 12, 13, 0},
                {0, 3, 11, 12, 5, 5, 12, 5, 5, 5, 12, 3, 11, 11, 12, 12, 13, 13, 13, 13, 12, 11, 11, 11, 12, 12, 5, 5, 5, 14, 14, 14, 14, 5, 5, 14, 14, 14, 14, 14, 14, 14, 14, 5, 5, 14, 5, 5, 5, 14, 14, 14, 14, 14, 14, 14, 12, 5, 5, 5, 5, 5, 12, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 12, 12, 13, 13, 0},
                {0, 11, 11, 12, 5, 12, 12, 5, 5, 5, 12, 11, 11, 12, 5, 5, 5, 12, 5, 5, 12, 11, 3, 11, 11, 12, 12, 5, 14, 5, 5, 5, 12, 5, 14, 5, 5, 5, 5, 5, 5, 5, 5, 14, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 14, 12, 5, 5, 5, 5, 12, 12, 12, 11, 11, 3, 11, 11, 11, 11, 11, 11, 11, 12, 13, 13, 13, 0},
                {0, 11, 12, 5, 5, 12, 12, 5, 5, 5, 12, 11, 12, 12, 5, 5, 12, 12, 5, 5, 5, 12, 11, 11, 11, 12, 12, 12, 5, 5, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 12, 12, 5, 5, 5, 12, 12, 12, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 12, 5, 12, 12, 0},
                {0, 11, 12, 5, 12, 12, 5, 5, 5, 5, 5, 12, 12, 5, 5, 12, 12, 5, 5, 5, 5, 12, 11, 11, 11, 11, 12, 12, 5, 5, 5, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 12, 12, 5, 5, 5, 12, 12, 12, 12, 11, 11, 3, 11, 11, 11, 11, 12, 5, 12, 12, 5, 0},
                {0, 12, 5, 12, 12, 5, 5, 5, 5, 5, 12, 12, 5, 5, 12, 12, 5, 5, 5, 5, 5, 5, 12, 11, 3, 11, 12, 12, 5, 5, 12, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 12, 5, 5, 5, 5, 12, 12, 12, 11, 11, 11, 11, 11, 12, 12, 12, 12, 12, 5, 5, 0},
                {0, 5, 12, 12, 5, 5, 5, 5, 5, 5, 12, 5, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 12, 11, 11, 12, 12, 12, 5, 5, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 12, 5, 5, 5, 5, 12, 12, 12, 11, 11, 11, 12, 5, 5, 12, 5, 5, 5, 5, 0},
                {0, 12, 12, 5, 5, 5, 5, 5, 5, 12, 5, 5, 5, 12, 12, 5, 5, 5, 5, 5, 5, 5, 12, 12, 11, 12, 12, 5, 5, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 12, 5, 5, 5, 5, 12, 12, 12, 12, 12, 5, 12, 12, 5, 5, 5, 5, 5, 0},
                {0, 12, 5, 5, 5, 5, 5, 5, 5, 12, 12, 12, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 12, 5, 5, 5, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 12, 5, 5, 5, 5, 12, 12, 5, 12, 12, 12, 5, 5, 5, 5, 5, 5, 0},
                {0, 5, 5, 5, 5, 5, 5, 5, 12, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 12, 12, 5, 5, 5, 12, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 12, 12, 5, 5, 5, 5, 5, 12, 12, 12, 5, 5, 5, 5, 5, 5, 5, 5, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //15
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 6, 6, 9, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 6, 6, 9, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 6, 6, 9, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 6, 6, 9, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 6, 6, 9, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 6, 6, 9, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 9, 9, 9, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }, //16 
        };
        static public int[,] boopImg = new int[,]
        {
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 3, 3, 3, 3, 3, 3, 3, 3, 3, 9, 5, 5, 5, 9, 9, 9, 0, 9, 9, 9, 9, 0, 9, 9, 9, 5, 5, 5, 9, 3, 3, 3, 3, 3, 3, 3, 3, 3, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 0},
            {0, 9, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 9, 9, 3, 3, 3, 3, 0, 3, 3, 3, 3, 9, 9, 7, 9, 9, 9, 9, 9, 0, 7, 7, 0, 9, 9, 9, 9, 9, 7, 9, 9, 3, 3, 3, 3, 0, 3, 3, 3, 3, 9, 9, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 9, 0},
            {0, 9, 3, 7, 3, 7, 3, 7, 3, 3, 3, 3, 3, 3, 7, 3, 7, 3, 3, 9, 9, 3, 3, 3, 0, 0, 0, 3, 3, 3, 9, 9, 7, 9, 9, 9, 9, 9, 7, 0, 0, 7, 9, 9, 9, 9, 9, 7, 9, 9, 3, 3, 3, 0, 0, 0, 3, 3, 3, 9, 9, 3, 3, 7, 3, 7, 3, 3, 3, 3, 3, 3, 7, 3, 7, 3, 7, 3, 9, 0},
            {0, 9, 3, 7, 3, 3, 7, 3, 3, 7, 7, 3, 3, 7, 3, 3, 7, 3, 3, 9, 9, 3, 3, 0, 0, 0, 0, 0, 3, 3, 9, 9, 7, 9, 9, 9, 9, 9, 7, 0, 0, 7, 9, 9, 9, 9, 9, 7, 9, 9, 3, 3, 0, 0, 0, 0, 0, 3, 3, 9, 9, 3, 3, 7, 3, 3, 7, 3, 3, 7, 7, 3, 3, 7, 3, 3, 7, 3, 9, 0},
            {0, 9, 3, 7, 3, 7, 3, 7, 3, 3, 3, 3, 7, 3, 3, 3, 7, 3, 3, 9, 9, 3, 3, 0, 0, 0, 0, 0, 3, 3, 9, 9, 7, 9, 9, 9, 9, 9, 0, 7, 7, 0, 9, 9, 9, 9, 9, 7, 9, 9, 3, 3, 0, 0, 0, 0, 0, 3, 3, 9, 9, 3, 3, 7, 3, 3, 3, 7, 3, 3, 3, 3, 7, 3, 7, 3, 7, 3, 9, 0},
            {0, 9, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 9, 9, 3, 3, 0, 0, 0, 0, 0, 3, 3, 9, 9, 7, 9, 9, 9, 9, 0, 9, 9, 9, 9, 0, 9, 9, 9, 9, 7, 9, 9, 3, 3, 0, 0, 0, 0, 0, 3, 3, 9, 9, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 9, 0},
            {0, 9, 3, 3, 3, 3, 3, 7, 3, 3, 3, 3, 7, 3, 3, 3, 7, 3, 3, 9, 9, 3, 3, 3, 0, 0, 0, 3, 3, 3, 9, 9, 7, 9, 9, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 9, 9, 7, 9, 9, 3, 3, 3, 0, 0, 0, 3, 3, 3, 9, 9, 3, 3, 7, 3, 3, 3, 7, 3, 3, 3, 3, 7, 3, 3, 3, 3, 3, 9, 0},
            {0, 9, 3, 7, 7, 7, 3, 7, 3, 3, 3, 3, 7, 3, 3, 7, 3, 3, 3, 9, 9, 3, 3, 3, 3, 0, 3, 3, 3, 3, 9, 9, 7, 9, 9, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 9, 9, 7, 9, 9, 3, 3, 3, 3, 0, 3, 3, 3, 3, 9, 9, 3, 3, 3, 7, 3, 3, 7, 3, 3, 3, 3, 7, 3, 7, 7, 7, 3, 9, 0},
            {0, 9, 3, 3, 3, 3, 3, 7, 3, 3, 3, 3, 7, 3, 7, 3, 3, 3, 3, 9, 9, 3, 3, 3, 3, 3, 3, 3, 3, 3, 9, 9, 7, 9, 9, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 9, 9, 7, 9, 9, 3, 3, 3, 3, 3, 3, 3, 3, 3, 9, 9, 3, 3, 3, 3, 7, 3, 7, 3, 3, 3, 3, 7, 3, 3, 3, 3, 3, 9, 0},
            {0, 9, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 9, 9, 3, 3, 3, 3, 3, 3, 3, 3, 3, 9, 9, 7, 9, 9, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 9, 9, 7, 9, 9, 3, 3, 3, 3, 3, 3, 3, 3, 3, 9, 9, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 9, 0},
            {0, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 3, 9, 3, 9, 3, 9, 3, 9, 9, 9, 7, 9, 9, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 9, 9, 7, 9, 9, 9, 3, 9, 3, 9, 3, 9, 3, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 0},
            {0, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 3, 9, 3, 9, 3, 9, 9, 9, 9, 7, 9, 9, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 9, 9, 7, 9, 9, 9, 9, 3, 9, 3, 9, 3, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 0},
            {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
            {0, 12, 12, 5, 7, 4, 7, 4, 7, 5, 12, 12, 12, 12, 12, 12, 12, 12, 12, 5, 4, 7, 4, 4, 7, 5, 12, 12, 12, 12, 12, 12, 7, 12, 12, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 12, 12, 7, 12, 12, 12, 12, 12, 12, 5, 7, 4, 7, 4, 4, 5, 12, 12, 12, 12, 12, 12, 12, 12, 12, 5, 7, 4, 7, 4, 7, 5, 12, 12, 0},
            {0, 12, 12, 5, 4, 7, 4, 7, 4, 5, 12, 12, 12, 7, 7, 7, 12, 12, 12, 5, 4, 4, 7, 7, 4, 5, 12, 12, 12, 12, 12, 12, 7, 12, 12, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 12, 12, 7, 12, 12, 12, 12, 12, 12, 5, 4, 7, 4, 4, 4, 5, 12, 12, 12, 7, 7, 7, 12, 12, 12, 5, 4, 7, 4, 7, 4, 5, 12, 12, 0},
            {0, 12, 12, 5, 4, 4, 7, 4, 4, 5, 12, 12, 12, 7, 5, 7, 12, 12, 12, 5, 4, 9, 7, 4, 4, 5, 12, 12, 12, 12, 12, 12, 7, 12, 12, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 12, 12, 7, 12, 12, 12, 12, 12, 12, 5, 7, 4, 4, 1, 4, 5, 12, 12, 12, 7, 5, 7, 12, 12, 12, 5, 4, 4, 7, 4, 4, 5, 12, 12, 0},
            {0, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 12, 7, 7, 7, 12, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 12, 12, 12, 12, 7, 12, 12, 7, 0, 0, 0, 0, 0, 0, 4, 0, 7, 12, 12, 7, 12, 12, 12, 12, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 12, 7, 7, 7, 12, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 0},
            {0, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 7, 11, 7, 5, 7, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 12, 12, 12, 12, 7, 12, 12, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 12, 12, 7, 12, 12, 12, 12, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 7, 9, 7, 11, 7, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 0},
            {0, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 7, 5, 7, 5, 7, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 12, 12, 12, 12, 7, 12, 12, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 12, 12, 7, 12, 12, 12, 12, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 7, 5, 7, 5, 7, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 0},
            {0, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 7, 1, 7, 1, 7, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 12, 12, 12, 12, 7, 12, 12, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 12, 12, 7, 12, 12, 12, 12, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 7, 5, 7, 1, 7, 12, 12, 5, 4, 4, 4, 4, 4, 5, 12, 12, 0},
            {0, 12, 12, 5, 5, 5, 5, 5, 5, 5, 12, 12, 7, 5, 7, 5, 7, 12, 12, 5, 5, 5, 5, 5, 5, 5, 12, 12, 12, 12, 12, 12, 7, 12, 12, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 12, 12, 7, 12, 12, 12, 12, 12, 12, 5, 5, 5, 5, 5, 5, 5, 12, 12, 7, 5, 7, 5, 7, 12, 12, 5, 5, 5, 5, 5, 5, 5, 12, 12, 0},
            {0, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 7, 9, 7, 11, 7, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 7, 12, 12, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 12, 12, 7, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 7, 11, 7, 9, 7, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 0},
            {0, 12, 12, 12, 7, 12, 7, 12, 7, 12, 12, 12, 7, 7, 7, 7, 7, 12, 12, 12, 7, 12, 7, 12, 7, 12, 12, 12, 12, 12, 12, 5, 5, 5, 12, 7, 0, 0, 0, 0, 0, 0, 0, 0, 7, 12, 5, 5, 5, 12, 12, 12, 12, 12, 12, 7, 12, 7, 12, 7, 12, 12, 12, 7, 7, 7, 7, 7, 12, 12, 12, 7, 12, 7, 12, 7, 12, 12, 12, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };
        static void Main()
        {
            Console.WindowWidth = 80;
            droppedItemsIdRuins.Add("key");
            droppedItemsLocationRuins.Add(20);
            
            Insructions();
        }
        static void DrawImg()
        {
            if (mapLocation != 16)
            {
                for (int x = 0; x < 14; x++)
                {
                    for (int i = 0; i < 80; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Black;
                        if (mapImg[mapLocation, x, i] == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 3)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 4)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 5)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 6)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 7)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 8)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 9)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 11)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 12)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 13)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("x");
                        }
                        else if (mapImg[mapLocation, x, i] == 14)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("x");
                        }
                    }
                    Console.Write("");
                }
            }
            else
            {
                for (int x = 0; x < 25; x++)
                {
                    for (int i = 0; i < 80; i++)
                    {
                        if (boopImg[x, i] == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 3)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 4)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 5)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 6)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 7)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 8)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 9)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 11)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 12)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 13)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("x");
                        }
                        else if (boopImg[x, i] == 14)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("x");
                        }
                    }
                }
            }
        }
        static void Display()
        {
            Console.Clear();
            DrawImg();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(mapNames[mapLocation]);
            if (isVampire == false && isDrunk == false)
            {
                Console.WriteLine(mapMessage[mapLocation]);
            }
            else if (isVampire == false && isDrunk == true)
            {
                Console.WriteLine(mapMessageDrunk[mapLocation]);
            }
            else if (isVampire == true && isDrunk == false)
            {
                if (mapLocation == 12)
                {
                    if (vampiresDead == false)
                    {
                        Console.WriteLine(vampVampireCaveMsg[0]);
                    }
                    else
                    {
                        Console.WriteLine(vampVampireCaveMsg[1]);
                    }
                }
                else
                {
                    Console.WriteLine(mapMessageVamp[mapLocation]);
                }
            }
            else
            {
                Console.WriteLine(mapMessageDrunkVamp[mapLocation]);
            }

            Console.WriteLine("\n");
            if (bag.Count != 0)
            {
                Console.Write("You have: ");
                for (int item = 0; item < bag.Count; item++)
                {
                    if (item == 0)
                    {
                        Console.Write(bag[item]);
                    }
                    else
                    {
                        Console.Write(", " + bag[item]);
                    }
                }
                Console.Write(" in your bag. ");
            }
            

            Console.WriteLine("You have " + silver + " silver");
            if (droppedItemsLocationOverworld != null)
            {
                string groundItems = "";
                for (int item = 0;item < droppedItemsLocationOverworld.Count; item++)
                {
                    if (droppedItemsLocationOverworld[item] == mapLocation)
                    {
                        groundItems = groundItems + (droppedItemsIdOverworld[item] + " ");
                    }
                }
                if (groundItems != "")
                {
                    Console.WriteLine("On the ground is: " + groundItems);
                }
            }
            if (talkMsg != "")
            {
                Console.WriteLine("\n" + talkMsg);
                talkMsg = "";
            }
            if (ErrorMsg != "")
            {
                Console.WriteLine("\n" + ErrorMsg);
                ErrorMsg = "";
            }
            if (hasHorse == true)
            {
                Console.WriteLine("You have a horse named " + horseName);
            }
            PlayersInput();
        

        }
        static void Insructions()
        {
            Console.Clear();
            Console.WriteLine(
                "This is a texted based adventure game. Type what you want to do in the Console. There are certain key words" +
                " that trigger the action. Some of the known key wordsare: North, East, South, West, Give, Drop, Grab, and Talk. " +
                "This game is not casesensative. If you ever need help type 'instructions' and this message will pop  up again. " +
                "\n\n\nPress Enter to begin the game."
                );
            Console.Write("");
            string but = Console.ReadLine();
            if (but == "abc")
            {
                silver = 10000;
            }
            Display();
        }
        static void PlayersInput()
        {
            Console.Write("");
            string input = Console.ReadLine().ToLower();
            bool worked = false;
            int oldLocation = map[mapLocation];
            List<string> oldBag = new List<string>();
            foreach (string item in bag)
            {
                oldBag.Add(item);
            }
            //Credit to https://docs.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
            //how to split a string into parts
            string[] words = input.Split(' ');
            foreach (string word in words)
            {
                switch (word)
                {
                    case "instructions":
                        Insructions();
                        break;
                    case "north":
                        worked = true;
                        if (mapLocation <= 3)
                        {
                            if (mapLocation == 0)
                            {
                                ErrorMsg = "You will get lost in the Ocean";
                            }
                            else
                            {
                                ErrorMsg = "You will fall into the Ocean";
                            }
                        }
                        else
                        {
                            mapLocation -= 4;
                        }
                        break;
                    case "east":
                        worked = true;
                        if (mapLocation % 4 == 3)
                        {
                            if (mapLocation == 3)
                            {
                                ErrorMsg = "You will get lost in the fog";
                            }
                            else if (mapLocation == 7)
                            {
                                ErrorMsg = "You will get lost in the forest";
                            }
                            else if (mapLocation == 11)
                            {
                                AncientRuinExplore();
                            }
                            else if (mapLocation == 15)
                            {
                                ErrorMsg = "The Mountain is too steep to climb there.";
                            }
                        }
                        else
                        {
                            mapLocation++;
                        }
                        break;
                    case "south":
                        worked = true;
                        if (mapLocation >= 12)
                        {
                            if (mapLocation == 12)
                            {
                                VampireCaveExplore();
                            }
                            else if (mapLocation == 13)
                            {
                                ErrorMsg = "You will get lost in the farmland";
                            }
                            else if (mapLocation == 14)
                            {
                                ErrorMsg = "That is Employees only area";
                            }
                            else if (mapLocation == 15)
                            {
                                DragonFight();
                            }
                        }
                        else
                        {
                            mapLocation += 4;
                        }
                        break;
                    case "west":
                        worked = true;
                        if (mapLocation % 4 == 0)
                        {
                            if (mapLocation == 0)
                            {
                                ErrorMsg = "You will get lost in the Ocean.";
                            }
                            else if (mapLocation == 4)
                            {
                                ErrorMsg = "You will fall into the Ocean.";
                            }
                            else if (mapLocation == 8)
                            {
                                ErrorMsg = "Guards prevent you from enter the King and Queens room.";
                            }
                            else if (mapLocation == 12)
                            {
                                ErrorMsg = "The Mountain is too steep to climb there.";
                            }
                        }
                        else
                        {
                            mapLocation--;
                        }
                        break;
                    case "upupdowndownleftrightleftrightab":
                        worked = true;
                        if (mapLocation == 6)
                        {
                            mapLocation = 16;
                        }
                        else
                        {
                            ErrorMsg = "Unknown Command";
                        }
                        break;
                    case "talk":
                        switch (mapLocation)
                        {

                            case 1:
                                if (isDrunk == false && isVampire == false)
                                {
                                    talkMsg = "You want up to and ask one of the men whats going on. " +
                                        "He tells you that a ship sank close to the docks just on the west side. ";
                                }
                                else if (isDrunk == true && isVampire == false)
                                {
                                    talkMsg = "You want up to the one who looks like he is running the dock and he says " +
                                        "'HI, I AM MR MEESEEKS.'";
                                }
                                else if (isDrunk == false && isVampire == true)
                                {
                                    talkMsg = "You try to approach the man who is running the dock, but he runs away from you.";
                                }
                                else
                                {
                                    talkMsg = "You try to approach the one who appears to be running the docks, but he runs away from you.";
                                }
                                break;
                            case 2:
                                if (isDrunk == false)
                                {
                                    talkMsg = "You approach the monk who looks thirsty and he saids ' " +
                                        "Hey man can you get me something to drink I dont have time to go right now but im so thirsty. " +
                                        "I also have holy water for sale for 10 silver.'";
                                }
                                else
                                {
                                    talkMsg = "The demons make an incomprehensible sound. ";
                                }
                                break;
                            case 4:
                                if (isDrunk == false && isVampire == false)
                                {
                                    talkMsg = "You approach the man running the tavern and he tells you " +
                                        "'Beers a 5 silver'";
                                }
                                else if (isDrunk == false && isVampire == true)
                                {
                                    talkMsg = "You approach the man running the tavern and he tells you " +
                                        "'Beers a 10 silver'";
                                }
                                else if (isDrunk == true && isVampire == false)
                                {
                                    talkMsg = "You approach the man running the tavern and he tells you 'You have had too many for today pal'";
                                }
                                else
                                {
                                    talkMsg = "You approach the man running the tavern and he tells you 'You have had too many for today pal'";
                                }
                                break;
                            case 5:
                                if (isDrunk == false && isVampire == false)
                                {
                                    talkMsg = "You approach a man with many wears, he ask you, 'What do you want to buy? " +
                                        "I got armor for 20 silver, a sword for 10 silver, a dagger for 2 silver, a throwing axe for 5 silver, bow and arrow for 15 silver, " +
                                        "a shield for 5 silver and a lantern for 4 silver.'";
                                }
                                else if (isDrunk == true && isVampire == false)
                                {
                                    talkMsg = "You appoach a man with a lot of junk he saids 'What you blah blah, 4 silver, blah blah 3, blah blah 10, blah blah armor, blah blah blah.";
                                }
                                else
                                {
                                    talkMsg = "There is no one to talk you are are not let in.";
                                }
                                break;
                            case 6:
                                if (isVampire == false)
                                {
                                    talkMsg = "There are too many people shouting to talk to someone";
                                }
                                else
                                {
                                    talkMsg = "They are trying to kill you, why would you stop and talk to them";
                                }
                                break;
                            case 7:
                                if (isVampire == true)
                                {
                                    talkMsg = "There is no one there";
                                }
                                else if (isDrunk == true)
                                {
                                    talkMsg = "You are too high and drunk to be able to understand them";
                                }
                                else
                                {
                                    talkMsg = "They won't stop no matter how much you shout";
                                }
                                break;
                            case 8:
                                if (isDrunk == false && isVampire == false)
                                {
                                    talkMsg = "The King tells you of how their princess was kidnapped and they will pay lots of maoney " +
                                        "to whoever can save her";
                                }
                                else if (isDrunk == false && isVampire == true)
                                {
                                    talkMsg = "The King and Queen call for the Guards and kill you";

                                    EndGame();
                                }
                                else if (isDrunk == true && isVampire == false)
                                {
                                    talkMsg = "The King and Queen call for the Guards and kill you";

                                    EndGame();
                                }
                                else
                                {
                                    talkMsg = "The King and Queen call for the Guards and kill you";

                                    EndGame();
                                }
                                break;
                            case 9:
                                if (isDrunk == false && isVampire == false)
                                {
                                    talkMsg = "The guards ignore you";
                                }
                                else if (isDrunk == false && isVampire == true)
                                {
                                    talkMsg = "The guards kill you";

                                    EndGame();
                                }
                                else if (isDrunk == true && isVampire == false)
                                {
                                    talkMsg = "The guards ignore you";
                                }
                                else
                                {
                                    talkMsg = "The guards kill you";

                                    EndGame();
                                }
                                break;
                            case 10:
                                if (isDrunk == false && isVampire == false)
                                {
                                    talkMsg = "You approach the wizard and he says 'I have lots for sale but " +
                                        "my most popular items are healing potion for 15 silver and water breathing potion for 10 silver";
                                }
                                else if (isDrunk == false && isVampire == true)
                                {
                                    talkMsg = talkMsg = "You approach the wizard and he says 'I have lots for sale but " +
                                        "my most popular items are healing potion for 15 silver and " +
                                        "water breathing potion for 10 silver, however the last one would not help someone of your kind.";

                                }
                                else if (isDrunk == true && isVampire == false)
                                {
                                    talkMsg = "You are dead";
                                }
                                else
                                {
                                    talkMsg = "You are dead";
                                }
                                break;
                            case 14:
                                if (isDrunk == false && isVampire == false)
                                {
                                    talkMsg = "You walk up to the man running the stable and ask about the horse for sale, He said ' That one is for sale for 15 silver.'";
                                }
                                else if (isDrunk == false && isVampire == true)
                                {
                                    talkMsg = "The man calls the guard, they will come and kill you. You got to go quickly";
                                }
                                else if (isDrunk == true && isVampire == false)
                                {
                                    talkMsg = "The donkey men refuse to talk back to you";
                                }
                                else
                                {
                                    talkMsg = "The donkey men just keep insulting you.";
                                }
                                break;
                            case 16:
                                if (isDrunk == false && isVampire == false)
                                {
                                    talkMsg = "You go and talk to the guy at the counter, he says ' so you need shows, do ya? That will be 2 silver";
                                }
                                else if (isDrunk == false && isVampire == true)
                                {
                                    talkMsg = "You go and talk to the guy at the counter, he says ' so you need shows, do ya? We " +
                                        "don't see many of your kind around here, that will be just 1 silver.";

                                }
                                else if (isDrunk == true && isVampire == false)
                                {
                                    talkMsg = "You go and talk to the guy at the counter, 'Blah blah blah bowling shoes, blah blah, 2 silver'";
                                }
                                else
                                {
                                    talkMsg = "You go and talk to the guy at the counter, he says ' Blah blah blah We " +
                                        "don't see your kind around here, blah blah 1 silver.";

                                }
                                break;
                            default:
                                talkMsg = "There is no one to talk to";
                                break;
                        }
                        worked = true;
                        break;
                    case "buy":
                        int oldSilver = silver;
                        foreach (string Item in words)
                        {
                            switch (Item)
                            {
                                case "fireball":
                                    if (mapLocation == 10)
                                    {
                                        if (silver >= 25)
                                        {
                                            bag.Add("fireball scroll");
                                            silver -= 25;
                                        }
                                        else
                                        {
                                            ErrorMsg = "You can't afford that";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "That is not for sale here";
                                    }
                                    break;
                                case "sword":
                                    if (mapLocation == 5)
                                    {
                                        if (silver >= 10)
                                        {
                                            bag.Add("sword");
                                            silver -= 10;
                                        }
                                        else
                                        {
                                            ErrorMsg = "You can't afford that";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "That is not for sale here";
                                    }
                                    break;
                                case "water":
                                    if (ItemNameCheck(Item, words) == true)
                                    {
                                        if (mapLocation == 10)
                                        {
                                            if (silver >= 10)
                                            {
                                                bag.Add("water breathing potion");
                                                silver -= 10;
                                            }
                                            else
                                            {
                                                ErrorMsg = "You can't afford that";
                                            }
                                        }
                                        else
                                        {
                                            ErrorMsg = "That is not for sale here";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "What item is that";
                                    }
                                    break;
                                case "armor":
                                    if (mapLocation == 5)
                                    {
                                        if (silver >= 20)
                                        {
                                            bag.Add("armor");
                                            silver -= 20;
                                        }
                                        else
                                        {
                                            ErrorMsg = "You can't afford that";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "That is not for sale here";
                                    }
                                    break;
                                case "holy":
                                    if (ItemNameCheck(Item, words) == true)
                                    {
                                        if (mapLocation == 2)
                                        {
                                            if (silver >= 10)
                                            {
                                                bag.Add("holy water");
                                                silver -= 10;
                                            }
                                            else
                                            {
                                                ErrorMsg = "You can't afford that";
                                            }
                                        }
                                        else
                                        {
                                            ErrorMsg = "You can't afford that";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "What item?";
                                    }
                                    break;
                                case "horse":
                                    if (mapLocation == 14)
                                    {
                                        if (silver >= 15 && hasHorse == false)
                                        {
                                            hasHorse = true;
                                            silver -= 15;
                                            Console.Clear();
                                            Console.Write("Enter your horse's name: ");
                                            horseName = Console.ReadLine();
                                        }
                                        else if (hasHorse == true)
                                        {
                                            ErrorMsg = "You already bought the only horse for sail";
                                        }
                                        else
                                        {
                                            ErrorMsg = "You cant afford that";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "That is not sold here";
                                    }
                                    break;
                                case "shield":
                                    if (mapLocation == 5)
                                    {
                                        if (silver >= 5)
                                        {
                                            bag.Add("shield");
                                            silver -= 5;
                                        }
                                        else
                                        {
                                            ErrorMsg = "You can't afford that";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "That is not sold here";
                                    }
                                    break;
                                case "booze":
                                    if (mapLocation == 4)
                                    {
                                        if (isVampire == true)
                                        {
                                            if (silver >= 10)
                                            {
                                                bag.Add("booze");
                                                silver -= 10;
                                            }
                                            else
                                            {
                                                ErrorMsg = "You can't afford that";
                                            }
                                        }
                                        else
                                        {
                                            if (silver >= 5)
                                            {
                                                bag.Add("booze");
                                                silver -= 5;
                                            }
                                            else
                                            {
                                                ErrorMsg = "You can't afford that";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "That is not sold here";
                                    }
                                    break;
                                case "healing":
                                    if (ItemNameCheck(Item, words) == true)
                                    {
                                        if (mapLocation == 10)
                                        {
                                            if (silver >= 15)
                                            {
                                                bag.Add("healing potion");
                                                silver -= 15;
                                            }
                                            else
                                            {
                                                ErrorMsg = "You can't afford that";
                                            }
                                        }
                                        else
                                        {
                                            ErrorMsg = "That is not sold here";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "What Item";
                                    }
                                    break;
                                case "bow":
                                    if (ItemNameCheck(Item, words) == true)
                                    {
                                        if (mapLocation == 5)
                                        {
                                            if (silver >= 15)
                                            {
                                                bag.Add("bow and arrow");
                                                silver -= 15;
                                            }
                                            else
                                            {
                                                ErrorMsg = "You can't afford that";
                                            }
                                        }
                                        else
                                        {
                                            ErrorMsg = "That is not sold here";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "What item";
                                    }
                                    break;
                                case "dagger":
                                    if (mapLocation == 5)
                                    {
                                        if (silver >= 2)
                                        {
                                            bag.Add("dagger");
                                            silver -= 2;
                                        }
                                        else
                                        {
                                            ErrorMsg = "You can't afford that";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "That is not sold here";
                                    }
                                    break;
                                case "throwing":
                                    if (ItemNameCheck(Item, words) == true)
                                    {
                                        if (mapLocation == 5)
                                        {
                                            if (silver >= 5)
                                            {
                                                bag.Add("thorwing axe");
                                                silver -= 5;
                                            }
                                            else
                                            {
                                                ErrorMsg = "You can't afford that";
                                            }
                                        }
                                        else
                                        {
                                            ErrorMsg = "That item is not sold here";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "What item";
                                    }
                                    break;
                                case "lantern":
                                    if (mapLocation == 5)
                                    {
                                        if (silver >= 4)
                                        {
                                            bag.Add("lantern");
                                            silver -= 4;
                                        }
                                        else
                                        {
                                            ErrorMsg = "You can't afford that";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "That item is not sold here";
                                    }
                                    break;
                            }
                        }
                        if (oldSilver == silver && ErrorMsg == "")
                        {
                            ErrorMsg = "What item";
                        }
                        worked = true;
                        break;
                    case "drink":
                        foreach (string Item in words)
                        {
                            if (Item == "booze")
                            {
                                for (int bagItem = 0; bagItem < oldBag.Count; bagItem++)
                                {
                                    if (oldBag[bagItem] == "booze")
                                    {
                                        bag.Remove(oldBag[bagItem]);
                                        isDrunk = true;
                                        worked = true;
                                    }
                                }
                                if (worked == false)
                                {
                                    ErrorMsg = "You don't have any booze to drink";
                                    worked = true;
                                }
                            }
                            else if (ItemNameCheck(Item, words) == true)
                            {
                                for (int bagItem = 0; bagItem < oldBag.Count; bagItem++)
                                {
                                    if (oldBag[bagItem] == "water breathing potion")
                                    {
                                        hasWaterBreathing = true;
                                        bag.Remove("water breathing potion");
                                        worked = true;
                                    }
                                }
                            }
                        }
                        if (worked == false)
                        {
                            ErrorMsg = "You can't drink that";
                            worked = true;
                        }
                        break;
                    case "give":
                        bool holyWaterDrink = false;
                        foreach (string Item in words)
                        {
                            if (Item == "booze")
                            {
                                for (int bagItem = 0; bagItem < oldBag.Count; bagItem++)
                                {
                                    if (oldBag[bagItem] == "booze")
                                    {
                                        if (mapLocation == 2 && gotHolyWater == true)
                                        {
                                            ErrorMsg = "STOP DOPING SHIT, WALDO";
                                            worked = true;
                                        }
                                        else if (mapLocation == 2 && gotHolyWater == false)
                                        {
                                            gotHolyWater = true;
                                            worked = true;
                                            bag.Remove("booze");
                                            bag.Add("holy water");
                                            break;
                                        }
                                        
                                    }
                                    if (oldBag[bagItem] == "holy water")
                                    {
                                        holyWaterDrink = true;
                                    }
                                }
                                if (worked == false && holyWaterDrink == false)
                                {
                                    ErrorMsg = "You don't have anything for him to drink.";
                                    worked = true;
                                }
                                else if (worked == false && holyWaterDrink == true)
                                {
                                    ErrorMsg = "People don't drink holy water";
                                    worked = true;
                                }
                            }
                        }
                        break;
                    case "drop":
                        foreach (string item in words)
                        {
                            for (int bagItem = 0; bagItem < oldBag.Count; bagItem++)
                            {
                                if ((ItemNameCheck(item, words) == true) && item == "holy")
                                {
                                    bag.Remove("holy water");
                                    droppedItemsIdOverworld.Add("holy water");
                                    droppedItemsLocationOverworld.Add(mapLocation);
                                    worked = true;
                                    break;
                                }
                                else if ((ItemNameCheck(item, words) == true) || item == oldBag[bagItem])
                                {
                                    bag.Remove(oldBag[bagItem]);
                                    droppedItemsIdOverworld.Add(oldBag[bagItem]);
                                    droppedItemsLocationOverworld.Add(mapLocation);
                                    worked = true;
                                    break;
                                }
                            }
                        }
                        break;
                    case "grab":
                        if (droppedItemsLocationOverworld.Count != 0)
                        {
                            foreach (int location in droppedItemsLocationOverworld)
                            {
                                if (mapLocation == location)
                                {
                                    bag.Add(droppedItemsIdOverworld[droppedItemsLocationOverworld.IndexOf(location)]);
                                    droppedItemsIdOverworld.Remove(droppedItemsIdOverworld[droppedItemsLocationOverworld.IndexOf(location)]);
                                    droppedItemsLocationOverworld.Remove(droppedItemsLocationOverworld[droppedItemsLocationOverworld.IndexOf(location)]);
                                    worked = true;
                                    break;
                                }

                            }

                            if (oldBag == bag)
                            {
                                ErrorMsg = "There is no item to grab here";
                            }
                        }
                        else
                        {
                            ErrorMsg = "There is no item to grab here";
                        }
                        worked = true;
                        break;
                    case "kami":
                        Stupid();
                        worked = true;
                        break;
                }
            }
            if (mapLocation == 0)
            {
                if (hasWaterBreathing == false && isVampire == false)
                {
                    mapLocation = map[oldLocation];
                    ErrorMsg = "You can't go into the Ocean, you can't breath";
                }
            }
            if (worked == false)
            {
                ErrorMsg = "Unknown Command";
            }
            if (isDrunk == true)
            {
                if (mapLocation == 10 && isVampire == false)
                {
                    EndGame();
                }
                if (mapLocation == 9 && hasArmor == false)
                {
                    hasArmor = true;
                    bag.Add("armor");
                }
            }
            if (isVampire == true)
            {
                if (mapLocation == 2)
                {
                    EndGame();
                }
                if (mapLocation == 8)
                {
                    EndGame();
                }
                if (mapLocation == 9)
                {
                    EndGame();
                }
            }
            if (mapLocation == 0 && shipGold == false)
            {
                silver = silver + 20;
                shipGold = true;
                talkMsg = "You take 20 silver";
            }
            Display();
        }

        static public int ruinMapLocation = 1;

        static public string[] ruinMapMessage =
        {
            "You walk into a room covered in moss and mold. You see a chest with a lock on it.", //0
            "You walk into a room covered in moss and mold.", //1
            "You walk into a room covered in moss and mold.", //2
            "You walk into a room covered in moss and mold.", //3
            "You walk into a room covered in moss and mold.", //4
            "You walk into a room covered in moss and mold.", //7
            "You walk into a room covered in moss and mold.", //6
            "You walk into a room covered in moss and mold.", //7
            "You walk into a room covered in moss and mold.", //8
            "You walk into a room covered in moss and mold.", //9
            "You walk into a room covered in moss and mold.", //10
            "You walk into a room covered in moss and mold.", //11
            "You walk into a room covered in moss and mold.", //12
            "You walk into a room covered in moss and mold.", //13
            "You walk into a room covered in moss and mold.", //14
            "You walk into a room covered in moss and mold.", //17
            "You walk into a room covered in moss and mold.", //16
            "You walk into a room covered in moss and mold.", //17
            "You walk into a room covered in moss and mold.", //18
            "You walk into a room covered in moss and mold.", //19
            "You walk into a room covered in moss and mold.", //20
        };
        static public string[] ruinDoorMessages =
        {
            "There is a door to the east.", //0
            "There is the entrance stairs to the north, and a door way to the east, south and west.", //1
            "There is a door to the west.", //2
            "There is a door to the south.", //3
            "There is a door to the east.", //4
            "There is a door to the north, east, south, and west", //7
            "There is a door to the east and west.", //6
            "There is a door to the west.", //7
            "There is a door to the north and east.", //8
            "There is a door to the east, south, west.", //9
            "There is a door to the north, south and west.", //10
            "There is a door to the east and south.", //11
            "There is a door to the south and west.", //12
            "There is a door to the east.", //13
            "There is a door to the north and west.", //14
            "There is a door to the north, east, and south", //17
            "There is a door to the north and west.", //16
            "There is a door to the north.", //17
            "There is a door to the east.", //18
            "There is a door to the north, east, and west.", //19
            "There is a door to the west.", //20
        };

        static public List<int> droppedItemsLocationRuins = new List<int>();
        static public List<string> droppedItemsIdRuins = new List<string>();

        static void AncientRuinExplore()
        {
            for (int i = 0; i < bag.Count; i++)
            {
                switch (bag[i])
                {
                    case "lantern":
                        hasLantern = true;
                        break;
                }
            }
            int[] ancientRuinMap =
            {
                    0, 1, 2,
                 3, 4, 5, 6, 7,
                 8, 9, 10, 11, 12,
                13, 14, 15, 16, 17, 
                    18, 19, 20
            };
            AncientRuinExploreDisplay();
        } 
        static void AncientRuinExploreInput()
        {
            Console.WriteLine("\n\n");
            Console.Write("");
            string input = Console.ReadLine().ToLower();
            bool worked = false;
            int oldLocation = map[mapLocation];
            //https://docs.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
            //how to split a string into parts
            string[] words = input.Split(' ');
            //***************************************
            //NEEDS MORE INPUTS
            //***************************************
            foreach (var word in words)
            {
                switch (word)
                {
                    case "north":
                        if (ruinMapLocation == 1)
                        {
                            Display();
                            worked = true;
                        }
                        else if (ruinMapLocation == 5)
                        {
                            ruinMapLocation = 1;
                            worked = true;
                        }
                        else if (ruinMapLocation == 8)
                        {
                            ruinMapLocation = 3;
                            worked = true;
                        }
                        else if (ruinMapLocation == 10)
                        {
                            ruinMapLocation = 5;
                            worked = true;
                        }
                        else if (ruinMapLocation == 14)
                        {
                            ruinMapLocation = 9;
                            worked = true;
                        }
                        else if (ruinMapLocation == 15)
                        {
                            ruinMapLocation = 10;
                            worked = true;
                        }
                        else if (ruinMapLocation == 16)
                        {
                            ruinMapLocation = 11;
                            worked = true;
                        }
                        else if (ruinMapLocation == 17)
                        {
                            ruinMapLocation = 12;
                            worked = true;
                        }
                        else if (ruinMapLocation == 19)
                        {
                            ruinMapLocation = 15;
                            worked = true;
                        }
                        else
                        {
                            ErrorMsg = "Their is not a door their";
                        }
                        break;
                    case "east":
                        if (ruinMapLocation == 0)
                        {
                            ruinMapLocation++;
                            worked = true;
                        }
                        else if (ruinMapLocation == 1)
                        {
                            ruinMapLocation++;
                            worked = true;
                        }
                        else if (ruinMapLocation == 4)
                        {
                            ruinMapLocation++;
                            worked = true;
                        }
                        else if (ruinMapLocation == 5)
                        {
                            ruinMapLocation++;
                            worked = true;
                        }
                        else if (ruinMapLocation == 6)
                        {
                            ruinMapLocation++;
                            worked = true;
                        }
                        else if (ruinMapLocation == 8)
                        {
                            ruinMapLocation++;
                            worked = true;
                        }
                        else if (ruinMapLocation == 9)
                        {
                            ruinMapLocation++;
                            worked = true;
                        }
                        else if (ruinMapLocation == 11)
                        {
                            ruinMapLocation++;
                            worked = true;
                        }
                        else if (ruinMapLocation == 13)
                        {
                            ruinMapLocation++;
                            worked = true;
                        }
                        else if (ruinMapLocation == 15)
                        {
                            ruinMapLocation++;
                            worked = true;
                        }
                        else if (ruinMapLocation == 18)
                        {
                            ruinMapLocation++;
                            worked = true;
                        }
                        else if (ruinMapLocation == 19)
                        {
                            ruinMapLocation++;
                            worked = true;
                        }
                        else
                        {
                            ErrorMsg = "Their is not a door their";
                        }
                        break;
                    case "south":
                        if (ruinMapLocation == 1)
                        {
                            ruinMapLocation = 5;
                            worked = true;
                        }
                        else if (ruinMapLocation == 3)
                        {
                            ruinMapLocation = 8;
                            worked = true;
                        }
                        else if (ruinMapLocation == 5)
                        {
                            ruinMapLocation = 10;
                            worked = true;
                        }
                        else if (ruinMapLocation == 9)
                        {
                            ruinMapLocation = 14;
                            worked = true;
                        }
                        else if (ruinMapLocation == 10)
                        {
                            ruinMapLocation = 15;
                            worked = true;
                        }
                        else if (ruinMapLocation == 11)
                        {
                            ruinMapLocation = 16;
                            worked = true;
                        }
                        else if (ruinMapLocation == 12)
                        {
                            ruinMapLocation = 17;
                            worked = true;
                        }
                        else if (ruinMapLocation == 15)
                        {
                            ruinMapLocation = 19;
                            worked = true;
                        }
                        else
                        {
                            ErrorMsg = "Their is not a door their";
                        }
                        break;
                    case "west":
                        if (ruinMapLocation == 1)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else if (ruinMapLocation == 2)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else if (ruinMapLocation == 5)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else if (ruinMapLocation == 6)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else if (ruinMapLocation == 7)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else if (ruinMapLocation == 9)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else if (ruinMapLocation == 10)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else if (ruinMapLocation == 11)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else if (ruinMapLocation == 12)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else if (ruinMapLocation == 14)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else if (ruinMapLocation == 16)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else if (ruinMapLocation == 19)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else if (ruinMapLocation == 20)
                        {
                            ruinMapLocation--;
                            worked = true;
                        }
                        else
                        {
                            ErrorMsg = "Their is not a door their";
                        }
                        break;
                    case "grab":
                        List<string> oldBag = bag;
                        if (droppedItemsLocationRuins.Count != 0)
                        {
                            for (int i = 0; i < droppedItemsLocationRuins.Count; i++)
                            {
                                if (ruinMapLocation == droppedItemsLocationRuins[i])
                                {
                                    bag.Add(droppedItemsIdRuins[i]);
                                    droppedItemsIdRuins.Remove(droppedItemsIdRuins[i]);
                                    droppedItemsLocationRuins.Remove(droppedItemsLocationRuins[i]);
                                    worked = true;
                                }
                            }
                            if (oldBag == bag)
                            {
                                ErrorMsg = "There is no item to grab here";
                            }
                        }
                        else
                        {
                            ErrorMsg = "There is no item to grab here";
                        }
                        worked = true;
                        break;
                    case "use":
                        foreach (string phase in words)
                        {
                            for (int item = 0; item < bag.Count; item++)
                            {
                                if (bag[item] == phase)
                                {
                                    if (bag[item] == "key")
                                    {
                                        if (ruinMapLocation == 0)
                                        {
                                            UnlockChest();
                                        }
                                        else
                                        {
                                            ErrorMsg = "You cant use that here";
                                        }
                                    }
                                    else
                                    {
                                        ErrorMsg = "You cant use that here";
                                    }
                                }
                            }
                        }
                        worked = true;
                        break;
                }
            }
            if (worked == false)
            {
                ErrorMsg = "Unknown Command";
            }
            AncientRuinExploreDisplay();
        }
        static void UnlockChest()
        {
            if (chestUnlocked == false)
            {
                Console.WriteLine("When you open the chest you find a book, titled 'The Red Light Alley'. As you read the book " +
                    "You find many images that exite your heart");
                bag.Add("book");
                chestUnlocked = true;
            }
            else
            {
                ErrorMsg = "BRANDON STOP DUPING SHIT";
            }
        }
        static void AncientRuinExploreDisplay()
        {
           
            Console.Clear();
            if (isVampire == true)
            {
                Console.WriteLine("You feel a force pulling you toword one of the crosses. The force pulls you in and you touch " +
                        "the cross. As you burst into flames you hear little girls singing. " +
                        "'One, two, Freddy's coming for you. Three, four, Better lock your door Five, six, grab a crucifix. " +
                        "Seven, eight, gonna better stay awake. Nine, ten, He's back again.'");
                Console.WriteLine("You died, enter to restart the game.");
                Console.ReadLine();
                EndGame();
            }
            else if (hasLantern)
            {
                Console.WriteLine(ruinMapMessage[ruinMapLocation]);
                Console.WriteLine(ruinDoorMessages[ruinMapLocation]);
                Console.WriteLine("\n");
                if (bag.Count != 0)
                {
                    Console.Write("You have: ");
                    for (int item = 0; item < bag.Count; item++)
                    {
                        if (item == 0)
                        {
                            Console.Write(bag[item]);
                        }
                        else
                        {
                            Console.Write(", " + bag[item]);
                        }
                    }
                    Console.Write(" in your bag. ");
                }
                Console.WriteLine("You have " + silver + " silver");
                Console.Write("\n");
                string groundItems = "";
                for (int item = 0; item < droppedItemsLocationRuins.Count; item++)
                {
                    if (droppedItemsLocationRuins[item] == ruinMapLocation)
                    {
                        groundItems = groundItems + (droppedItemsIdRuins[item] + " ");
                    }
                }
                if (groundItems != "")
                {
                    Console.WriteLine("On the ground is: " + groundItems);
                }
                if (ErrorMsg != "")
                {
                    Console.WriteLine(ErrorMsg);
                    ErrorMsg = "";
                }
            }
            else
            {
                ErrorMsg = "It is too dark to see, so you turn around. Maybe there are lanterns at the      Merchant's " +
                    "Guild";
                Display();
            }
            AncientRuinExploreInput();
            
        }
        static void DragonFight()
        {
            int bossPoints = 75;
            if (dragonKilled == false)
            {
                if (hasHorse == true)
                {
                    if (bag.Count > 5)
                    {
                        Console.WriteLine("You and your horse try to climb the mountain, " +
                               "however you are carrying too much but you are determined " +
                               "to power through. When you and your horse finally reach the top, you " +
                               " and your horse collapse from exhaustion. The two of you " +
                               "then become the dragons next meal.");
                    }
                    else
                    {
                        foreach (string item in bag)
                        {
                            switch (item)
                            {
                                case "sword":
                                    bossPoints = bossPoints - 15;
                                    break;
                                case "armor":
                                    bossPoints = bossPoints - 40;
                                    break;
                                case "shield":
                                    bossPoints = bossPoints - 10;
                                    break;
                                case "booze":
                                    bossPoints = bossPoints + 10;
                                    break;
                                case "healing potion":
                                    bossPoints = bossPoints - 30;
                                    break;
                                case "bow and arrow":
                                    bossPoints = bossPoints - 20;
                                    break;
                                case "dagger":
                                    bossPoints = bossPoints - 5;
                                    break;
                                case "throwing axe":
                                    bossPoints = bossPoints - 10;
                                    break;
                                case "book":
                                    bossPoints = bossPoints - 10;
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    if (bag.Count > 3)
                    {
                        Console.WriteLine("You try to climb the mountain, " +
                                "however you are carrying too much but you are determined " +
                                "to power through. When you finally reach the top, you " +
                                "collapse from exhaustion. You then become the dragons next meal.");
                    }
                    else
                    {
                        foreach (string item in bag)
                        {
                            switch (item)
                            {
                                case "sword":
                                    bossPoints = bossPoints - 15;
                                    break;
                                case "armor":
                                    bossPoints = bossPoints - 40;
                                    break;
                                case "shield":
                                    bossPoints = bossPoints - 10;
                                    break;
                                case "booze":
                                    bossPoints = bossPoints + 10;
                                    break;
                                case "healing potion":
                                    bossPoints = bossPoints - 30;
                                    break;
                                case "bow and arrow":
                                    bossPoints = bossPoints - 20;
                                    break;
                                case "dagger":
                                    bossPoints = bossPoints - 5;
                                    break;
                                case "throwing axe":
                                    bossPoints = bossPoints - 10;
                                    break;
                                case "book":
                                    bossPoints = bossPoints - 10;
                                    break;
                            }
                        }
                    }
                }
                if (bossPoints == 75)
                {
                    if (bag.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You walk up and gave no fight, he ate you whole.");
                    }
                    Console.ReadLine();
                    EndGame();
                }
                else if (bossPoints > 0)
                {
                    Console.Clear();
                    Console.WriteLine("You put up a good fight but the dragon bested you. You are his next meal.");
                    Console.ReadLine();
                    EndGame();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You slay the dragon and save the princes. As a reward she gives you 1000 silver");
                    silver = silver + 1000;
                    dragonKilled = true;
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("You already slayed the dragon. There are not infinate dragons in this little area.");
                Console.ReadLine();
            }
            
        }
        static void EndGame()
        {
            Console.Clear();
            if (mapLocation == 2 && isDrunk == true)
            {
                Console.WriteLine(mapMessageDrunkVamp[2]);
            }
            else if (mapLocation == 2 && isDrunk == false)
            {
                Console.WriteLine(mapMessageVamp[2]);
            }
            if (mapLocation == 10 && isDrunk == true)
            {
                Console.WriteLine(mapMessageDrunk[10]);
            }
            if (mapLocation == 8 && isVampire == true)
            {
                Console.WriteLine(mapMessageVamp[8]);
            }
            if (mapLocation == 9 && isVampire == true)
            {
                Console.WriteLine(mapMessageVamp[9]);
            }
            List<string> bagContents = new List<string>();
            List<string> droppedItemCountOverworld = new List<string>();
            List<string> droppedItemCountRuins = new List<string>();
            for (int x = 0; x < bag.Count; x++)
            {
                bagContents.Add(bag[x]);
            }
            for (int x = 0; x < bagContents.Count; x++)
            {
                bag.Remove(bagContents[x]);
            }
            for (int x = 0; x < droppedItemsIdOverworld.Count; x++)
            {
                droppedItemCountOverworld.Add(droppedItemsIdOverworld[x]);
            }
            for (int x = 0; x < droppedItemCountOverworld.Count; x++)
            {
                droppedItemsIdOverworld.Remove(droppedItemCountOverworld[x]);
                droppedItemsLocationOverworld.Remove(droppedItemsLocationOverworld[0]);
            }
            for (int x = 0; x < droppedItemsIdRuins.Count; x++)
            {
                droppedItemCountRuins.Add(droppedItemsIdRuins[x]);
            }
            for (int x = 0; x < droppedItemCountRuins.Count; x++)
            {
                droppedItemsIdRuins.Remove(droppedItemCountRuins[x]);
                droppedItemsLocationRuins.Remove(droppedItemsLocationRuins[0]);
            }
            hasLantern = false;
            isDrunk = false;
            isVampire = false;
            hasWaterBreathing = false;
            hasHorse = false;
            hasArmor = false;
            ErrorMsg = "";
            talkMsg = "";
            silver = 50;
            mapLocation = 6;
            dragonKilled = false;
            vampiresDead = false;
            Console.Write("You Lose, Press enter to restart");
            Console.ReadLine();
            Main();

        }
        static void VampireCaveExplore()
        {
            Console.Clear();
            bool hasHolyWater = false;
            
            for (int i = 0; i < bag.Count; i++)
            {
                switch (bag[i])
                {
                    case "holy water":
                        hasHolyWater = true;
                        break;
                    case "armor":
                        hasArmor = true;
                        break;
                    case "lantern":
                        hasLantern = true;
                        break;
                }
            }
            if (vampiresDead == true)
            {
                Console.WriteLine("You already save the damsel that was in distress.");
            }
            else if (hasLantern && hasArmor && hasHolyWater)
            {
                Console.WriteLine("You couldn't see until you lit the lantern. You then drenched all the vampires with the holy water. " +
                    "One of them tried to bite you but your armor stopped him from getting to you. The woman you saved gave you 70 silver " +
                    "to pay you for saving her.");
                silver += 70;
                vampiresDead = true;
            }
            else
            {
                if (hasLantern)
                {
                    if (hasArmor)
                    {
                        Console.WriteLine("You couldn't see until you lit the lantern. One of the vampires tried to bite you but couldn't get past your armor. " +
                            "But you had no way to kill them. They kept trying to bite through your armor until they pieced it. They turned you into a vampire");
                    }
                    else
                    {
                        Console.WriteLine("You couldn't see until you lit the lantern. Whe you headed further one of them jumped and bit you." +
                            " You are now a vampire");
                    }
                }
                else if (hasArmor)
                {
                    if (hasHolyWater)
                    {
                        Console.WriteLine("You can't see as you walked into the cave. Your holy water was knocked out of your hands. You can feel sharp objects poking into your " +
                            "armor until it is pieced. You can feel 2 fangs biting into you. You are now a vampire");
                    }
                    else
                    {
                        Console.WriteLine("You can't see as you walked into the cave. You can feel sharp objects poking into your " +
                            "armor until it is pieced. You can feel 2 fangs biting into you. You are now a vampire");
                    }
                }
                else if (hasHolyWater)
                {
                    if (hasLantern)
                    {
                        Console.WriteLine("You can't see until you light the lantern. You walk in and drench all the vampires with holy " +
                            "water. You however get bitten before you could kill all of them. You are now a vampire");
                    }
                    else
                    {
                        Console.WriteLine("You can't see as you walked into the cave. Your holy water was knocked out of your hands." +
                            " You can feel 2 fangs biting into you. You are now a vampire");
                    }
                }
                else
                {
                    Console.WriteLine("You can't see. You walk in you however get bitten. You are now a vampire");
                }
                isVampire = true;
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        static bool ItemNameCheck(string itemName, string[] words)
        {
            bool word1 = false;
            bool word2 = false;
            if (itemName == "water")
            {
                foreach (string word in words)
                {
                    if (word == "breathing")
                    {
                        word1 = true;
                    }
                    if (word == "potion")
                    {
                        word2 = true;
                    }
                }
                if (word1 == true && word2 == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (itemName == "holy")
            {
                foreach (string word in words)
                {
                    if (word == "water")
                    {
                        return true;
                    }
                }
            }
            else if (itemName == "healing")
            {
                foreach (string word in words)
                {
                    if (word == "potion")
                    {
                        return true;
                    }
                }
            }
            else if (itemName == "bow")
            {
                foreach (string word in words)
                {
                    if (word == "and" || word == "n")
                    {
                        word1 = true;
                    }
                    if (word == "arrow" || word == "arrows")
                    {
                        word2 = true;
                    }
                }
                if (word1 == true && word2 == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (itemName == "throwing")
            {
                foreach (string word in words)
                {
                    if (word == "axe")
                    {
                        return true;
                    }
                    if (word == "axes")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static void Stupid()
        {
            Console.Clear();
            int[,] img = new int[,]
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 7, 3, 3, 7, 7, 7, 3, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 7, 7, 3, 7, 7, 7, 7, 3, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 3, 7, 7, 7, 7, 3, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 3, 3, 7, 7, 7, 3, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 3, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 3, 7, 7, 7, 3, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 3, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 3, 7, 7, 7, 3, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 6, 6, 0, 0, 0, 0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 6, 6, 0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 6, 6, 6, 6, 6, 6, 0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0, 0, 0, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };
            for (int x = 0; x < 25; x++)
            {
                for (int i = 0; i < 80; i++)
                {
                    if (img[x, i] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("x");
                    }
                    else if (img[x, i] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("x");
                    }
                    else if (img[x, i] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("x");
                    }
                    else if (img[x, i] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("x");
                    }
                    else if (img[x, i] == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("x");
                    }
                    else if (img[x, i] == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("x");
                    }
                    else if (img[x, i] == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("x");
                    }
                    else if (img[x, i] == 7)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("x");
                    }
                    else if (img[x, i] == 8)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("x");
                    }
                    else if (img[x, i] == 9)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("x");
                    }
                    else if (img[x, i] == 11)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("x");
                    }
                    else if (img[x, i] == 12)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("x");
                    }
                    else if (img[x, i] == 13)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("" +
                            "x");
                    }
                    else if (img[x, i] == 14)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("x");
                    }
                }
                Console.WriteLine(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
