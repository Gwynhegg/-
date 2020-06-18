using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MapObjects
{
    public interface IObject
    {

    }

    public interface ITreasure : IObject
    {
        Treasure Treasure { get; set; }
    }

    public interface IOwner : IObject
    {
        int Owner { get; set; }
    }

    public interface IArmy : IObject
    {
        Army Army { get; set; }
    }

    public class Dwelling : IOwner
    {
        public int Owner { get; set; }
    }

    public class Mine : IOwner, IArmy, ITreasure
    {
        public int Owner { get; set; }
        public Army Army { get; set; }
        public Treasure Treasure { get; set; }
    }

    public class Creeps: IArmy, ITreasure
    {
        public Army Army { get; set; }
        public Treasure Treasure { get; set; }
    }

    public class Wolfs: IArmy
    {
        public Army Army { get; set; }
    }

    public class ResourcePile: ITreasure
    {
        public Treasure Treasure { get; set; }
    }


    public static class Interaction 
    {

        public static void Make(Player player, IObject mapObject)
        {
            if (mapObject is IArmy)
            {
                if (!player.CanBeat(((IArmy)mapObject).Army))
                    {
                    player.Die();
                    return;
                    }
            }
            if (mapObject is IOwner) ((IOwner)mapObject).Owner = player.Id;
            if (mapObject is ITreasure) player.Consume(((ITreasure)mapObject).Treasure);
            
        }
        /*
        public static void Make(Player player, object mapObject)
        { 
            
            if (mapObject is Dwelling)
            {
                ((Dwelling)mapObject).Owner = player.Id;
                return;
            }
            if (mapObject is Mine)
            {
                if (player.CanBeat(((Mine)mapObject).Army))
                {
                    ((Mine)mapObject).Owner = player.Id;
                    player.Consume(((Mine)mapObject).Treasure);
                }
                else player.Die();
                return;
            }
            if (mapObject is Creeps)
            {
                if (player.CanBeat(((Creeps)mapObject).Army))
                    player.Consume(((Creeps)mapObject).Treasure);
                else
                    player.Die();
                return;
            }
            if (mapObject is ResourcePile)
            {
                player.Consume(((ResourcePile)mapObject).Treasure);
                return;
            }
            if (mapObject is Wolfs)
            {
                if (!player.CanBeat(((Wolfs)mapObject).Army))
                    player.Die();
            }
        }*/
    }
}
