using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo="Eat fish", Line = "eate fish carfully", Platform = "on a plate"},
                new Command{Id = 1, HowTo="Eat meat", Line = "eate fish carfully", Platform = "on a plate"},
                new Command{Id = 2, HowTo="Eat stuff", Line = "eate fish carfully", Platform = "on a plate"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id = 0, HowTo="Eat fish", Line = "eate fish carfully", Platform = "on a plate"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}