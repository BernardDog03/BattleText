namespace BattleText.Data
{
    public class GamePlayManager
    {
        public static void ValidationInput(int inputGame)
        {
            bool validInput = false;

            while (!validInput)
            {
                string? input = Console.ReadLine();
                if (int.TryParse(input, out inputGame) && inputGame >= 1 && inputGame <= 5)
                {
                    validInput = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please choose number between 1 to 5!");
                }
            }
        }
    }
}