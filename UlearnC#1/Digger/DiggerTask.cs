using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digger
{
    //Напишите здесь классы Player, Terrain и другие.
    public class Player : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            CreatureCommand cc = new CreatureCommand();
            cc.DeltaY = cc.DeltaX = 0;
            cc.TransformTo = new Player();
            if (Game.KeyPressed == Keys.Up && y > 0 && !(Game.Map[x, y - 1] is Sack))
                cc.DeltaY = -1;
            if (Game.KeyPressed == Keys.Down && y < Game.MapHeight - 1 && !(Game.Map[x, y + 1] is Sack))
                cc.DeltaY = 1;
            if (Game.KeyPressed == Keys.Left && x > 0 && !(Game.Map[x - 1, y] is Sack) && (y == Game.MapHeight - 1 || !(Game.Map[x - 1, y + 1] is Sack)))
                cc.DeltaX = -1;
            if (Game.KeyPressed == Keys.Right && x < Game.MapWidth - 1 && !(Game.Map[x + 1, y] is Sack) && (y == Game.MapHeight - 1 || !(Game.Map[x + 1, y + 1] is Sack)))
                cc.DeltaX = 1;

            return cc;
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return false;
        }

        public int GetDrawingPriority()
        {
            return 0;
        }

        public string GetImageFileName()
        {
            return "Digger.png";
        }
    }

    public class Terrain : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand() { TransformTo = new Terrain() };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            if (conflictedObject != this)
                return conflictedObject != this;
            return false;
        }

        public int GetDrawingPriority()
        {
            return 0;
        }

        public string GetImageFileName()
        {
            return "Terrain.png";
        }
    }

    public class Sack : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            if (y < Game.MapHeight - 1 && Game.Map[x, y + 1] is null )
                return new CreatureCommand() { DeltaY=1, TransformTo = new Sack() };
            return new CreatureCommand() { TransformTo = new Sack() };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            if (conflictedObject != this)
                return conflictedObject != this;
            return false;
        }

        public int GetDrawingPriority()
        {
            return 0;
        }

        public string GetImageFileName()
        {
            return "Sack.png";
        }
    }

    public class Gold : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand() { TransformTo = new Gold() };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            if (conflictedObject != this)
                return conflictedObject != this;
            return false;
        }

        public int GetDrawingPriority()
        {
            return 0;
        }

        public string GetImageFileName()
        {
            return "Gold.png";
        }
    }
}
