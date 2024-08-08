using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace BattleText.Data
{
    public class Characters
    {
        //Characters Name and Element
        public static string[] character_name = new string[] { "Mythical Knight", "Goddess Aphrodite", "Ancient Assassin", "Sun Goddess", "Electro Shaman" };
        public static string[] element_character = new string[] { "Wind", "Water", "Rock", "Fire", "Electro" };
        public static string[] attack_element_one = new string[] { "Tornado Blast", "Hydro Resturaction", "Rock Smash", "Inferno", "Storm Blast" };
        public static string[] attack_element_two = new string[] { "Wind Slasher", "waterfall Smash", "Stone Breaker", "Flame Heal", "Thunder Strike" };
        public static string[] attack_burst = new string[] { "Heavenly Tempest", "Oceanic Tsunami", "Earthquake", "Lava Eruption", "Electro Storm" };
        public static string[] type_attack_element_one = new string[] { "cc", "heal", "dmg", "dmg", "buff" };
        public static string[] type_attack_element_two = new string[] { "dmg", "dmg", "def", "heal", "dmg" };
        public static string[] type_attack_burst = new string[] { "buff", "cc", "dmg", "dmg", "cc" };

        //Basic Characters stats
        public static int[] hp_character = new int[] { 220, 200, 300, 250, 210 };
        public static int[] def_character = new int[] { 100, 150, 200, 130, 120 };
        public static int[] skill_point_element_one = new int[] { 1, 3, 2, 2, 2 };
        public static int[] skill_point_element_two = new int[] { 2, 2, 1, 3, 2 };
        public static int[] skill_point_burst = new int[] { 7, 6, 7, 5, 5 };

        //Attack Character stats
        public static int[] attack_point_character_basic = new int[] { 12, 11, 7, 14, 13 };
        public static int[] attack_point_character_element_one = new int[] { 5, 75, 27, 29, 10 };
        public static int[] attack_point_character_element_two = new int[] { 30, 33, 75, 65, 21 };
        public static int[] attack_point_character_burst = new int[] { 20, 15, 47, 49, 20 };

        public static void CharacterDetails(int select)
        { 
            Console.WriteLine("========================================");
            Console.WriteLine("Character Name: " + character_name[select]);
            Console.WriteLine("========================================");
            Console.WriteLine("Element: " + element_character[select]);
            Console.WriteLine("========================================");
            Console.WriteLine("Hp: " + hp_character[select]);
            Console.WriteLine("Def: " + def_character[select]);
            Console.WriteLine("Att: " + attack_point_character_basic[select]);
            Console.WriteLine("========================================");
            Console.WriteLine("Basic Skill : " + attack_element_one[select] + $"( -{skill_point_element_one[select]} SP)");
            Console.WriteLine("Basic Skill Damage : " + attack_point_character_element_one[select]);
            Console.WriteLine("========================================");
            Console.WriteLine("Elemental Skill : " + attack_element_two[select] + $"(-{skill_point_element_two[select]} SP)");
            Console.WriteLine("Elemental Skill Damage : " + attack_point_character_element_two[select]);
            Console.WriteLine("========================================");
            Console.WriteLine("Basic Skill : " + attack_burst[select] + $"( -{skill_point_burst[select]} SP)");
            Console.WriteLine("Burst Damage : " + attack_point_character_burst[select]);
            Console.WriteLine("========================================\n\n");
        }
    }
}