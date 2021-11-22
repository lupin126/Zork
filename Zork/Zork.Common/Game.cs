using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ComponentModel;
using Zork.Common;
using Newtonsoft.Json;

namespace Zork
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonIgnore]
        public static Game Instance { get; private set; }

        public World World { get; set; }

        [JsonIgnore]
        public Player Player { get; set; }

        public IInputService Input { get; set; }

        public IOutputService Output { get; set; }

        [JsonIgnore]
        public CommandManager CommandManager { get; }

        [JsonIgnore]
        public bool IsRunning { get; private set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        public Game() => CommandManager = new CommandManager();

        public static void StartFromFile(string gameFileName, IInputService input, IOutputService output)
        {
            if (!File.Exists(gameFileName))
            {
                throw new FileNotFoundException("Expexted file.", gameFileName);
            }

            Start(File.ReadAllText(gameFileName), input, output);
        }

        public static void Start(string gameJsonString, IInputService input, IOutputService output)
        {
            Instance = Load(gameJsonString);
            Assert.IsNotNull(input);
            Instance.Input = input;
            Assert.IsNotNull(output);
            Instance.Output = output;
            Instance.LoadCommands();
            Instance.DisplayWelcomeMessage();
            Instance.IsRunning = true;
            Instance.Input.InputReceived += Instance.InputReceivedHandler;
        }

        private void InputReceivedHandler(object sender, string inputString)
        {
            Room previousRoom = Player.Location;
            if (CommandManager.PerformCommand(this, inputString.Trim()))
            {
                Player.moves++;

                if (previousRoom != Player.Location)
                {
                    CommandManager.PerformCommand(this, "LOOK");
                }
            }
            else
            {
                Output.WriteLine("That's not a verb I recognize.");
            }
        }

        public void Quit() => IsRunning = false;

        public static Game Load(string jsonString)
        {
            Game game = JsonConvert.DeserializeObject<Game>(jsonString);
            game.Player = game.World.SpawnPlayer();

            return game;
        }

        private void LoadCommands()
        {
            var commandMethods = (from type in Assembly.GetExecutingAssembly().GetTypes()
                                  from method in type.GetMethods()
                                  let attribute = method.GetCustomAttribute<CommandAttribute>()
                                  where type.IsClass && type.GetCustomAttribute<CommandClassAttribute>() != null
                                  where attribute != null
                                  select new Command(attribute.CommandName, attribute.Verbs, (Action<Game, CommandContext>)Delegate.CreateDelegate(typeof(Action<Game, CommandContext>), method)));

            CommandManager.AddCommands(commandMethods);
        }

        public bool ConfirmAction(string prompt)
        {
            return true;
            //Instance.Output.Write(prompt);

            //while (true)
            //{
            //    string response = Console.ReadLine().Trim().ToUpper();
            //    if (response == "YES" || response == "Y")
            //    {
            //        return true;
            //    }
            //    else if (response == "NO" || response == "N")
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        Console.Write("Please answer yes or no.> ");
            //    }
            //}
        }

        private void DisplayWelcomeMessage() => Output.WriteLine(World.WelcomeMessage);
    }
}
