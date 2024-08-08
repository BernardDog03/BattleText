using System.Collections;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using BattleText.Data;

namespace BattleText;

class BattleManager
{
    enum State
    {
        start_game,
        character_select_phase,
        character_confirm_phase,
        preparation,
        character_action,
        enemy_take_damage,
        enemy_action,
        character_take_damage,
        return_preparation,
        battle_over
    }
    static void Main(String[] args)
    {
        State currentState = State.start_game;

        int inputGame;
        int seleceted = 0;

        bool validInput = false;

        while (true)
        {
            switch (currentState)
            {
                case State.start_game:
                    Console.WriteLine("Press Y to Play!");
                    while (!validInput)
                    {
                        string? input = Console.ReadLine();
                        if (input == "Y" | input == "y")
                        {
                            validInput = true;
                            currentState = State.character_select_phase;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Press Y to Play!");
                        }
                    }
                    validInput = false;
                    break;

                case State.character_select_phase:
                    Console.Clear();
                    Console.WriteLine("=========================\n==WELCOME TO BATTLE TEXT==\n=========================\nChoose Your Character\n");
                    Console.WriteLine("1. " + Characters.character_name[0]);
                    Console.WriteLine("2. " + Characters.character_name[1]);
                    Console.WriteLine("3. " + Characters.character_name[2]);
                    Console.WriteLine("4. " + Characters.character_name[3]);
                    Console.WriteLine("5. " + Characters.character_name[4]);
                    Console.WriteLine("6. Cancel");
                    Console.Write("\nYour Character: ");
                    while (!validInput)
                    {
                        string? input = Console.ReadLine();
                        if (int.TryParse(input, out inputGame) && inputGame >= 1 && inputGame <= 6)
                        {
                            validInput = true;
                            Console.Clear();
                            if(inputGame == 0)
                            {
                                currentState = State.start_game;
                            }
                            else
                            {
                                seleceted = inputGame;
                                currentState = State.character_confirm_phase;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("=========================\n==WELCOME TO BATTLE TEXT==\n=========================\nChoose Your Character\n");
                            Console.WriteLine("1. " + Characters.character_name[0]);
                            Console.WriteLine("2. " + Characters.character_name[1]);
                            Console.WriteLine("3. " + Characters.character_name[2]);
                            Console.WriteLine("4. " + Characters.character_name[3]);
                            Console.WriteLine("5. " + Characters.character_name[4]);
                            Console.WriteLine("6. Cancel");
                            Console.WriteLine("\nPlease choose a number between 1 and 6!");
                            Console.Write("Your Character: ");
                        }
                    }
                    validInput = false;
                    break;

                case State.character_confirm_phase:
                    Console.Clear();
                    int selectedCharacter = seleceted-1;
                    Characters.CharacterDetails(selectedCharacter);
                    Console.Write("Confirm this character? Y/N ");
                    while (!validInput)
                    {
                        string? input = Console.ReadLine();
                        if (input == "Y" | input == "y")
                        {
                            validInput = true;
                            currentState = State.preparation;
                        }
                        else if (input == "N" | input == "n")
                        {
                            validInput = true;
                            currentState = State.character_select_phase;
                        }
                        else
                        {
                            Console.Clear();
                            Characters.CharacterDetails(selectedCharacter);
                            Console.Write("Wrong Input, Press Y/N to Confirm! ");
                        }
                    }
                    validInput = false;
                    break;

                case State.preparation:
                    Console.Clear();
                    Console.Write("Press Any Key To Continue! ");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
