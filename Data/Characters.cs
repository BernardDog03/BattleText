namespace BattleText.Data
{
    public class Characters
    {
        public static void SelectedCharacter()
        {
            int selectedChara = 0;

            //Characters Name and Element
            string[] character = new string[] { "Mythical Knight", "Goddess Aphrodite", "Ancient Assassin", "Sun Goddess", "Electro Shaman" };
            string[] element = new string[] { "Wind", "Water", "Rock", "Fire", "Electro" };
            string[] attack_element_one = new string[] {"Aerial Blast", "Hydro Blast", "Rock Smash", "Inferno", "Storm Blast"};
            string[] attack_element_two = new string[] {"Wind Slasher", "waterfall Smash", "Stone Breaker", "Flame Burst", "Thunder Strike"};
            string[] attack_burst = new string[] {"Heavenly Tempest", "Oceanic Tsunami", "Earthquake", "Lava Eruption", "Electro Storm"};
            string[] type_attack_element_one = ["dmg", ]

            //Basic Characters stats
            int[] hp_character = new int[] { 220, 200, 300, 250, 210 };
            int[] def_character = new int[] { 100, 150, 200, 130, 120 };
            int[] burst_point = new int[] {};

            //Attack Character stats
            int[] attack_point_character_basic = new int[] { 12, 11, 7, 14, 13 };
            int[] attack_point_character_element_one = new int[] {};
            int[] attack_point_character_element_two = new int[] {};
            int[] attack_point_character_burst = new int[] {};

            Console.WriteLine("");

            GamePlayManager.ValidationInput(selectedChara);
        }
    }
}