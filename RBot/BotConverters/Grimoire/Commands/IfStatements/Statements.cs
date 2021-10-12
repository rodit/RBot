using Newtonsoft.Json;

namespace RBot.BotConverters.Grimoire.Commands.IfStatements
{
    public abstract class InvertStatement : IfStatement
    {
        [JsonProperty("$type")]
        public string Type { get; set; }

        public abstract string BaseStatement { get; }
        public virtual bool Invert => Type.Contains("Not");
        public override string Statement => (Invert ? "!" : "") + BaseStatement;
    }

    public abstract class EqualityStatement : InvertStatement
    {
        protected readonly string Op = "@<>@";

        public override bool Invert => Type.Contains("Not");
        public override string Statement => Invert ? BaseStatement.Replace(Op, "!=") : BaseStatement.Replace(Op, "==");
    }

    public abstract class InequalityStatement : InvertStatement
    {
        protected readonly string Op = "@<>@";

        public override bool Invert => Type.Contains("Greater");
        public override string Statement => Invert ? BaseStatement.Replace(Op, ">") : BaseStatement.Replace(Op, "<");
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdAvailableMonstersGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdAvailableMonstersLessThan")]
    public class AvailableMonstersGreaterThan : InequalityStatement
    {
        public override string BaseStatement => $"bot.Monsters.MapMonsters.Count {Op} {Value1.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdCellIs",
        "Grimoire.Botting.Commands.Misc.Statements.CmdCellIsNot")]
    public class CellIs : EqualityStatement
    {
        public override string BaseStatement => $"bot.Player.Cell {Op} {Value1.GetCode()}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdEquipped",
        "Grimoire.Botting.Commands.Misc.Statements.CmdNotEquipped")]
    public class Equipped : InvertStatement
    {
        public override string BaseStatement => $"bot.Inventory.IsEquipped({Value1.GetCode()})";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdFactionRankGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdFactionRankLessThan")]
    public class FactionRankGreaterThan : InequalityStatement
    {
        public override string BaseStatement => $"bot.Player.GetFactionRank({Value1.GetCode()}) {Op} {Value2.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdGoldGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdGoldLessThan")]
    public class GoldGreaterThan : InequalityStatement
    {
        public override string BaseStatement => $"bot.Player.Gold {Op} {Value1.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdHealthGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdHealthLessThan")]
    public class HealthGreaterThan : InequalityStatement
    {
        public override string BaseStatement => $"bot.Player.Health {Op} {Value1.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdHealthPercentageGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdHealthPercentageLessThan")]
    public class HealthPercentageGreaterThan : InequalityStatement
    {
        public override string BaseStatement => $"(float)bot.Player.Health / bot.Player.MaxHealth {Op} {Value1.GetCode("float")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdInBank",
        "Grimoire.Botting.Commands.Misc.Statements.CmdNotInBank")]
    public class InBank : InvertStatement
    {
        public override string BaseStatement => $"bot.Bank.Contains({Value1.GetCode()}, {Value2.GetCode("int")})";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdInCombat",
        "Grimoire.Botting.Commands.Misc.Statements.CmdNotInCombat")]
    public class InCombat : InvertStatement
    {
        public override string BaseStatement => "bot.Player.InCombat";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdInInventory",
        "Grimoire.Botting.Commands.Misc.Statements.CmdNotInInventory")]
    public class InInventory : InvertStatement
    {
        public override string BaseStatement => $"bot.Inventory.Contains({Value1.GetCode()}, {Value2.GetCode("int")})";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdInTemp",
        "Grimoire.Botting.Commands.Misc.Statements.CmdNotInTemp")]
    public class InTemp : InvertStatement
    {
        public override string BaseStatement => $"bot.Inventory.ContainsTempItem({Value1.GetCode()}, {Value2.GetCode("int")})";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdIntEqualInt",
        "Grimoire.Botting.Commands.Misc.Statements.CmdIntIs", "Grimoire.Botting.Commands.Misc.Statements.CmdIntIsNot", "Grimoire.Botting.Commands.Misc.Statements.CmdIntNotEqualInt")]
    public class IntEqualInt : EqualityStatement
    {
        public override string BaseStatement => $"{Value1.GetCode("int", true)} {Op} {Value2.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdIntGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdIntLessThan")]
    public class IntGreaterThan : InequalityStatement
    {
        public override string BaseStatement => $"{Value1.GetCode("int", true)} {Op} {Value2.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdIsMaxStack",
        "Grimoire.Botting.Commands.Misc.Statements.CmdIsNotMaxStack")]
    public class IsMaxStack : InvertStatement
    {
        public override string BaseStatement => $"bot.Inventory.IsMaxStack({Value1.GetCode()})";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdIsMember",
        "Grimoire.Botting.Commands.Misc.Statements.CmdIsNotMember")]
    public class IsMember : InvertStatement
    {
        public override string BaseStatement => "bot.Player.IsMember";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdItemPickupable",
        "Grimoire.Botting.Commands.Misc.Statements.CmdItemNotPickupable")]
    public class ItemPickupable : InvertStatement
    {
        public override string BaseStatement => $"bot.Player.DropExists({Value1.GetCode()})";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdLevelGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdLevelLessThan")]
    public class LevelGreaterThan : InequalityStatement
    {
        public override string BaseStatement => $"bot.Player.Level {Op} {Value1.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdLevelIs",
        "Grimoire.Botting.Commands.Misc.Statements.CmdLevelIsNot")]
    public class LevelIs : EqualityStatement
    {
        public override string BaseStatement => $"bot.Player.Level {Op} {Value1.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdManaGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdManaLessThan")]
    public class ManaGreaterThan : InequalityStatement
    {
        public override string BaseStatement => $"bot.Player.Mana {Op} {Value1.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdMapIs",
        "Grimoire.Botting.Commands.Misc.Statements.CmdMapIsNot")]
    public class MapIs : EqualityStatement
    {
        public override string BaseStatement => $"bot.Map.Name {Op} {Value1.GetCode()}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdMonsterHealthGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdMonsterHealthLessThan")]
    public class MonsterHealthGreaterThan : EqualityStatement
    {
        public override string BaseStatement => $"bot.Monsters.TryGetMonster({Value1.GetCode()}, out var __mon) && __mon.Health {Op} {Value2.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdMonsterInRoom",
        "Grimoire.Botting.Commands.Misc.Statements.CmdMonsterNotInRoom")]
    public class MonsterInRoom : InvertStatement
    {
        public override string BaseStatement => $"bot.Monsters.Exists({Value1.GetCode()})";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdPlayerEquippedClass",
        "Grimoire.Botting.Commands.Misc.Statements.CmdPlayerNotEquippedClass")]
    public class PlayerEquippedClass : EqualityStatement
    {
        public override string BaseStatement => $"bot.Inventory.CurrentClass.Name {Op} {Value1.GetCode()}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdPlayerInRoom",
        "Grimoire.Botting.Commands.Misc.Statements.CmdPlayerNotInRoom")]
    public class PlayerInRoom : InvertStatement
    {
        public override string BaseStatement => $"bot.Map.PlayerExists({Value1.GetCode()})";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdPlayerIsInCell",
        "Grimoire.Botting.Commands.Misc.Statements.CmdPlayerIsNotInCell")]
    public class PlayerInCell : EqualityStatement
    {
        public override string BaseStatement => $"bot.Map.TryGetPlayer({Value1.GetCode()}, out var __player) && __player.Cell {Op} {Value2.GetCode()}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdPlayerIsInMyCell",
        "Grimoire.Botting.Commands.Misc.Statements.CmdPlayerIsNotInMyCell")]
    public class PlayerInMyCell : EqualityStatement
    {
        public override string BaseStatement => $"bot.Map.TryGetPlayer({Value1.GetCode()}, out var __player) && __player.Cell {Op} bot.Player.Cell";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdPlayersGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdPlayersLessThan")]
    public class PlayersGreaterThan : InequalityStatement
    {
        public override string BaseStatement => $"bot.Map.PlayerCount {Op} {Value1.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdPlayersInCellGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdPlayersInCellLessThan")]
    public class PlayersInCellGreaterThan : InequalityStatement
    {
        public override string BaseStatement => $"bot.Map.Players.Where(p => p.Cell == {Value1.GetCode()}).Count() {Op} {Value2.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdPlayersInMyCellGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdPlayersInMyCellLessThan")]
    public class PlayersInMyCellGreaterThan : InequalityStatement
    {
        public override string BaseStatement => $"bot.Map.CellPlayers.Count {Op} {Value1.GetCode("int")}";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdQuestAvailable",
        "Grimoire.Botting.Commands.Misc.Statements.CmdQuestNotAvailable")]
    public class QuestAvailable : InvertStatement
    {
        public override string BaseStatement => $"bot.Quests.IsAvailable({Value1.GetCode("int")})";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdQuestCompleted",
        "Grimoire.Botting.Commands.Misc.Statements.CmdQuestNotCompleted")]
    public class QuestCompleted : InvertStatement
    {
        public override string BaseStatement => $"bot.Quests.CanComplete({Value1.GetCode("int")})";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdQuestInProgress",
        "Grimoire.Botting.Commands.Misc.Statements.CmdQuestNotInProgress")]
    public class QuestInProgress : InvertStatement
    {
        public override string BaseStatement => $"bot.Quests.IsInProgress({Value1.GetCode("int")})";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdSkillIsAvailable",
        "Grimoire.Botting.Commands.Misc.Statements.CmdSkillIsNotAvailable")]
    public class SkillIsAvailable : InvertStatement
    {
        public override string BaseStatement => $"bot.Player.CanUseSkill({Value1.GetCode("int")})";
    }

    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdVisibleMonstersGreaterThan",
        "Grimoire.Botting.Commands.Misc.Statements.CmdVisibleMonstersLessThan")]
    public class VisibleMonstersGreaterThan : InequalityStatement
    {
        public override string BaseStatement => $"bot.Monsters.CurrentMonsters.Count {Op} {Value1.GetCode("int")}";
    }
}
