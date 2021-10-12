using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;
using System.CodeDom;
using System.CodeDom.Compiler;

namespace RBot
{
    public static class BotConverter
    {
        private const string GrimoireKill = "Grimoire.Botting.Commands.Combat.CmdKill";
        private const string GrimoireKillFor = "Grimoire.Botting.Commands.Combat.CmdKillFor";
        private const string GrimoireRest = "Grimoire.Botting.Commands.Combat.CmdRest";
        private const string GrimoireBankSwap = "Grimoire.Botting.Commands.Item.CmdBankSwap";
        private const string GrimoireBankTransfer = "Grimoire.Botting.Commands.Item.CmdBankTransfer";
        private const string GrimoireBuy = "Grimoire.Botting.Commands.Item.CmdBuy";
        private const string GrimoireEquip = "Grimoire.Botting.Commands.Item.CmdEquip";
        private const string GrimoireGetDrop = "Grimoire.Botting.Commands.Item.CmdGetDrop";
        private const string GrimoireMapItem = "Grimoire.Botting.Commands.Item.CmdMapItem";
        private const string GrimoireSell = "Grimoire.Botting.Commands.Item.CmdSell";
        private const string GrimoireJoin = "Grimoire.Botting.Commands.Map.CmdJoin";
        private const string GrimoireTravel = "Grimoire.Botting.Commands.Map.CmdTravel";
        private const string GrimoireMoveToCell = "Grimoire.Botting.Commands.Map.CmdMoveToCell";
        private const string GrimoireWalk = "Grimoire.Botting.Commands.Map.CmdWalk";
        private const string GrimoireAcceptQuest = "Grimoire.Botting.Commands.Quest.CmdAcceptQuest";
        private const string GrimoireCompleteQuest = "Grimoire.Botting.Commands.Quest.CmdCompleteQuest";
        private const string GrimoireDelay = "Grimoire.Botting.Commands.Misc.CmdDelay";
        private const string GrimoireGotoLabel = "Grimoire.Botting.Commands.Misc.CmdGotoLabel";
        private const string GrimoireGotoPlayer = "Grimoire.Botting.Commands.Misc.CmdGotoPlayer";
        private const string GrimoireLabel = "Grimoire.Botting.Commands.Misc.CmdLabel";
        private const string GrimoireLogout = "Grimoire.Botting.Commands.Misc.CmdLogout";
        private const string GrimoirePacket = "Grimoire.Botting.Commands.Misc.CmdPacket";
        private const string GrimoireRestart = "Grimoire.Botting.Commands.Misc.CmdRestart";
        private const string GrimoireStop = "Grimoire.Botting.Commands.Misc.CmdStop";
        private const string GrimoireCellIs = "Grimoire.Botting.Commands.Misc.Statements.CmdCellIs";
        private const string GrimoireCellIsNot = "Grimoire.Botting.Commands.Misc.Statements.CmdCellIsNot";
        private const string GrimoireGoldGreaterThan = "Grimoire.Botting.Commands.Misc.Statements.CmdGoldGreaterThan";
        private const string GrimoireGoldLessThan = "Grimoire.Botting.Commands.Misc.Statements.CmdGoldLessThan";
        private const string GrimoireHealthGreaterThan = "Grimoire.Botting.Commands.Misc.Statements.CmdHealthGreaterThan";
        private const string GrimoireHealthLessThan = "Grimoire.Botting.Commands.Misc.Statements.CmdHealthLessThan";
        private const string GrimoireInBank = "Grimoire.Botting.Commands.Misc.Statements.CmdInBank";
        private const string GrimoireInCombat = "Grimoire.Botting.Commands.Misc.Statements.CmdInCombat";
        private const string GrimoireInInventory = "Grimoire.Botting.Commands.Misc.Statements.CmdInInventory";
        private const string GrimoireInTemp = "Grimoire.Botting.Commands.Misc.Statements.CmdInTemp";
        private const string GrimoireItemNotPickupable = "Grimoire.Botting.Commands.Misc.Statements.CmdItemNotPickupable";
        private const string GrimoireItemPickupable = "Grimoire.Botting.Commands.Misc.Statements.CmdItemPickupable";
        private const string GrimoireLevelGreaterThan = "Grimoire.Botting.Commands.Misc.Statements.CmdLevelGreaterThan";
        private const string GrimoireLevelIs = "Grimoire.Botting.Commands.Misc.Statements.CmdLevelIs";
        private const string GrimoireLevelLessThan = "Grimoire.Botting.Commands.Misc.Statements.CmdLevelLessThan";
        private const string GrimoireManaGreaterThan = "Grimoire.Botting.Commands.Misc.Statements.CmdManaGreaterThan";
        private const string GrimoireManaLessThan = "Grimoire.Botting.Commands.Misc.Statements.CmdManaLessThan";
        private const string GrimoireMapIs = "Grimoire.Botting.Commands.Misc.Statements.CmdMapIs";
        private const string GrimoireMapIsNot = "Grimoire.Botting.Commands.Misc.Statements.CmdMapIsNot";
        private const string GrimoireMonsterInRoom = "Grimoire.Botting.Commands.Misc.Statements.CmdMonsterInRoom";
        private const string GrimoireMonsterNotInRoom = "Grimoire.Botting.Commands.Misc.Statements.CmdMonsterNotInRoom";
        private const string GrimoireMonstersGreaterThan = "Grimoire.Botting.Commands.Misc.Statements.CmdMonstersGreaterThan";
        private const string GrimoireMonstersLessThan = "Grimoire.Botting.Commands.Misc.Statements.CmdMonstersLessThan";
        private const string GrimoireNotInBank = "Grimoire.Botting.Commands.Misc.Statements.CmdNotInBank";
        private const string GrimoireNotInCombat = "Grimoire.Botting.Commands.Misc.Statements.CmdNotInCombat";
        private const string GrimoireNotInInventory = "Grimoire.Botting.Commands.Misc.Statements.CmdNotInInventory";
        private const string GrimoireNotInTemp = "Grimoire.Botting.Commands.Misc.Statements.CmdNotInTemp";
        private const string GrimoirePlayerInRoom = "Grimoire.Botting.Commands.Misc.Statements.CmdPlayerInRoom";
        private const string GrimoirePlayerNotInRoom = "Grimoire.Botting.Commands.Misc.Statements.CmdPlayerNotInRoom";
        private const string GrimoirePlayersGreaterThan = "Grimoire.Botting.Commands.Misc.Statements.CmdPlayersGreaterThan";
        private const string GrimoirePlayersLessThan = "Grimoire.Botting.Commands.Misc.Statements.CmdPlayersLessThan";
        private const string GrimoireQuestCompleted = "Grimoire.Botting.Commands.Misc.Statements.CmdQuestCompleted";
        private const string GrimoireQuestNotCompleted = "Grimoire.Botting.Commands.Misc.Statements.CmdQuestNotCompleted";

        public static string GenCodeGrimoire(string file)
        {
            dynamic bot = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(file));
            string author = bot.Author;

            CodeStringBuilder sb = new CodeStringBuilder()
                .AppendLine("// Bot: " + Path.GetFileName(file))
                .AppendLine("// Author: " + author)
                .AppendLine("using System;")
                .AppendLine()
                .AppendLine("using RBot;")
                .AppendLine("using RBot.Servers;")
                .AppendLine()
                .AppendLine("public class Script")
                .AppendLine("{")
                .Indent()
                .AppendLine("public void ScriptMain(ScriptInterface bot)")
                .AppendLine("{")
                .Indent()
                .AppendLine("bot.Options.SafeTimings = true;")
                .AppendLine("bot.Options.RestPackets = true;")
                .AppendLine($"bot.Options.AutoRelogin = {ToBool(bot.AutoRelogin)};")
                .AppendLine($"bot.Options.ExitCombatBeforeQuest = {ToBool(bot.ExitCombatBeforeQuest)};")
                .AppendLine($"bot.Options.InfiniteRange = {ToBool(bot.InfiniteAttackRange)};")
                .AppendLine($"bot.Options.SkipCutscenes = {ToBool(bot.SkipCutscenes)};")
                .AppendLine($"bot.Options.WalkSpeed = {bot.WalkSpeed};")
                .If(bot.Server != null)
                .AppendLine($"bot.Options.LoginServer = ServerList.Servers.Find(x => x.Name == {ToLiteral(bot.Server.sName)});")
                .EndIf()
                .AppendLine()
                .AppendLine($"bot.Skills.SkillTimer = {bot.SkillDelay};");

            if (bot.Skills != null)
            {
                foreach (dynamic d in bot.Skills["$values"])
                    sb.AppendLine($"bot.Skills.Add({d.Index}, 1f);");
            }

            if(bot.Drops != null)
            {
                foreach (dynamic d in bot.Drops["$values"])
                    sb.AppendLine($"bot.Drops.Add({ToLiteral((string)d)});");
                sb.AppendLine("bot.Drops.Start();");
            }

            if(bot.Commands != null)
            {
                foreach (dynamic cmd in bot.Commands["$values"])
                {
                    string name = cmd["$type"];
                    name = name.Split(',')[0];
                    if (name == GrimoireKill)
                        sb.AppendLine($"bot.Player.Kill({ToLiteral(cmd.Monster)});");
                    else if (name == GrimoireKillFor)
                        sb.AppendLine($"bot.Player.KillForItem({ToLiteral(cmd.Monster)}, {ToLiteral(cmd.ItemName)}, {cmd.Quantity}{(cmd.ItemType == 1 ? ", true" : "")});");
                    else if (name == GrimoireRest)
                        sb.AppendLine($"bot.Player.Rest({((bool)cmd.Full).ToString().ToLower()});");
                    else if (name == GrimoireBankSwap)
                        sb.AppendLine($"bot.Bank.Swap({ToLiteral(cmd.InventoryItemName)}, {ToLiteral(cmd.BankItemName)});");
                    else if (name == GrimoireBankTransfer)
                    {
                        if ((cmd.TransferFromBank as bool?).GetValueOrDefault())
                            sb.AppendLine($"bot.Bank.ToInventory({ToLiteral(cmd.ItemName)});");
                        else
                            sb.AppendLine($"bot.Inventory.ToBank({ToLiteral(cmd.ItemName)});");
                    }
                    else if (name == GrimoireBuy)
                        sb.AppendLine($"bot.Shops.BuyItem({cmd.ShopId}, {ToLiteral(cmd.ItemName)});");
                    else if (name == GrimoireEquip)
                        sb.AppendLine($"bot.Player.EquipItem({ToLiteral(cmd.ItemName)});");
                    else if (name == GrimoireGetDrop)
                        sb.AppendLine($"bot.Player.Pickup({ToLiteral(cmd.ItemName)});");
                    else if (name == GrimoireMapItem)
                        sb.AppendLine($"bot.Map.GetMapItem({cmd.ItemId});");
                    else if (name == GrimoireSell)
                        sb.AppendLine($"bot.Shops.SellItem({ToLiteral(cmd.ItemName)}");
                    else if (name == GrimoireJoin || name == GrimoireTravel)
                        sb.AppendLine($"bot.Player.Join({ToLiteral(cmd.Map)}, {ToLiteral(cmd.Cell)}, {ToLiteral(cmd.Pad)});");
                    else if (name == GrimoireMoveToCell)
                        sb.AppendLine($"bot.Player.Jump({ToLiteral(cmd.Cell)}, {ToLiteral(cmd.Pad)});");
                    else if (name == GrimoireWalk)
                        sb.AppendLine($"bot.Player.WalkTo({cmd.X}, {cmd.Y});");
                    else if (name == GrimoireAcceptQuest)
                        sb.AppendLine($"bot.Quests.EnsureAccept({cmd.Quest.QuestID});");
                    else if (name == GrimoireCompleteQuest)
                    {
                        if (cmd.Quest.ItemId != null)
                            sb.AppendLine($"bot.Quests.EnsureComplete({cmd.Quest.QuestID}, {cmd.Quest.ItemId});");
                        else
                            sb.AppendLine($"bot.Quests.EnsureComplete({cmd.Quest.QuestID});");
                    }
                    else if (name == GrimoireDelay)
                        sb.AppendLine($"bot.Sleep({cmd.Delay});");
                    else if (name == GrimoireGotoLabel)
                        sb.AppendLine($"goto {((string)cmd.Label).SanitizeLabel()};");
                    else if (name == GrimoireGotoPlayer)
                        sb.AppendLine($"bot.Player.Goto({ToLiteral(cmd.PlayerName)});");
                    else if (name == GrimoireLabel)
                        sb.AppendLine($"{((string)cmd.Name).SanitizeLabel()}:");
                    else if (name == GrimoireLogout)
                        sb.AppendLine("bot.Player.Logout();");
                    else if (name == GrimoirePacket)
                        sb.AppendLine($"bot.SendPacket({ToLiteral(cmd.Packet)});");
                    else if (name == GrimoireRestart)
                        sb.AppendLine("ScriptManager.RestartScript();");
                    else if (name == GrimoireStop)
                        sb.AppendLine("ScriptManager.StopScript();");
                    else if (name == GrimoireCellIs)
                        sb.AppendIf($"bot.Player.Cell == {ToLiteral(cmd.Value1)}");
                    else if (name == GrimoireCellIsNot)
                        sb.AppendIf($"bot.Player.Cell != {ToLiteral(cmd.Value1)}");
                    else if (name == GrimoireGoldGreaterThan)
                        sb.AppendIf($"bot.Player.Gold >= {cmd.Value1}");
                    else if (name == GrimoireGoldLessThan)
                        sb.AppendIf($"bot.Player.Gold < {cmd.Value1}");
                    else if (name == GrimoireHealthGreaterThan)
                        sb.AppendIf($"bot.Player.Health >= {cmd.Value1}");
                    else if (name == GrimoireHealthLessThan)
                        sb.AppendIf($"bot.Player.Health < {cmd.Value1}");
                    else if (name == GrimoireInBank)
                        sb.AppendIf($"bot.Bank.Contains({ToLiteral(cmd.Value1)}, {((string)cmd.Value2).Replace("*", "1")})");
                    else if (name == GrimoireNotInBank)
                        sb.AppendIf($"!bot.Bank.Contains({ToLiteral(cmd.Value1)}, {((string)cmd.Value2).Replace("*", "1")})");
                    else if (name == GrimoireInCombat)
                        sb.AppendIf($"bot.Player.InCombat");
                    else if (name == GrimoireNotInCombat)
                        sb.AppendIf($"!bot.Player.InCombat");
                    else if (name == GrimoireInInventory)
                        sb.AppendIf($"bot.Inventory.Contains({ToLiteral(cmd.Value1)}, {((string)cmd.Value2).Replace("*", "1")})");
                    else if (name == GrimoireNotInInventory)
                        sb.AppendIf($"!bot.Inventory.Contains({ToLiteral(cmd.Value1)}, {((string)cmd.Value2).Replace("*", "1")})");
                    else if (name == GrimoireInTemp)
                        sb.AppendIf($"bot.Inventory.ContainsTempItem({ToLiteral(cmd.Value1)}, {((string)cmd.Value2).Replace("*", "1")})");
                    else if (name == GrimoireNotInTemp)
                        sb.AppendIf($"!bot.Inventory.ContainsTempItem({ToLiteral(cmd.Value1)}, {((string)cmd.Value2).Replace("*", "1")})");
                    else if (name == GrimoireItemNotPickupable)
                        sb.AppendIf($"!bot.Player.DropExists({ToLiteral(cmd.Value1)})");
                    else if (name == GrimoireItemPickupable)
                        sb.AppendIf($"bot.Player.DropExists({ToLiteral(cmd.Value1)})");
                    else if (name == GrimoireLevelGreaterThan)
                        sb.AppendIf($"bot.Player.Level >= {cmd.Value1}");
                    else if (name == GrimoireLevelLessThan)
                        sb.AppendIf($"bot.Player.Level < {cmd.Value1}");
                    else if (name == GrimoireManaGreaterThan)
                        sb.AppendIf($"bot.Player.Mana >= {cmd.Value1}");
                    else if (name == GrimoireManaLessThan)
                        sb.AppendIf($"bot.Player.Mana < {cmd.Value1}");
                    else if (name == GrimoireMapIs)
                        sb.AppendIf($"bot.Map.Name == {ToLiteral(cmd.Value1)}");
                    else if (name == GrimoireMapIsNot)
                        sb.AppendIf($"bot.Map.Name != {ToLiteral(cmd.Value1)}");
                    else if (name == GrimoireMonsterInRoom)
                        sb.AppendIf($"bot.Monsters.Exists({ToLiteral(cmd.Value1)})");
                    else if (name == GrimoireMonsterNotInRoom)
                        sb.AppendIf($"!bot.Monsters.Exists({ToLiteral(cmd.Value1)})");
                    else if (name == GrimoireMonstersGreaterThan)
                        sb.AppendIf($"bot.Monsters.CurrentMonsters.Count >= {cmd.Value1}");
                    else if (name == GrimoireMonstersLessThan)
                        sb.AppendIf($"bot.Monsters.CurrentMonsters.Count < {cmd.Value1}");
                    else if (name == GrimoirePlayerInRoom)
                        sb.AppendIf($"bot.Map.PlayerExists({ToLiteral(cmd.Value1)})");
                    else if (name == GrimoirePlayerNotInRoom)
                        sb.AppendIf($"!bot.Map.PlayerExists({ToLiteral(cmd.Value1)})");
                    else if (name == GrimoirePlayersGreaterThan)
                        sb.AppendIf($"bot.Map.CellPlayers.Count >= {cmd.Value1}");
                    else if (name == GrimoirePlayersLessThan)
                        sb.AppendIf($"bot.Map.CellPlayers.Count < {cmd.Value1}");
                    else if (name == GrimoireQuestCompleted)
                        sb.AppendIf($"bot.Quests.CanComplete({cmd.Value1})");
                    else if (name == GrimoireQuestNotCompleted)
                        sb.AppendIf($"!bot.Quests.CanComplete({cmd.Value1})");
                    else
                        sb.If(sb.InIf)
                            .Append("; ")
                            .EndIf()
                            .AppendLine($"// Unsupported command {name}.");
                }
            }

            sb.UnIndent()
                .AppendLine("}")
                .UnIndent()
                .AppendLine("}");

            return sb.ToString();
        }

        public static string ToBool(dynamic d)
        {
            return ((bool)d).ToString().ToLower();
        }

        public static string ToLiteral(dynamic d)
        {
            return ((string)d).ToLiteral();
        }

        public static StringBuilder AppendTabs(this StringBuilder sb, int count, int size = 4)
        {
            return sb.Append(Enumerable.Range(0, count * size).Select(i => ' ').ToArray());
        }

        private static string ToLiteral(this string input)
        {
            /*
            using (var writer = new StringWriter())
            {
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    provider.GenerateCodeFromExpression(new CodePrimitiveExpression(input), writer, null);
                    return writer.ToString();
                }
            }
            */
            return $"\"{input}\"";
        }

        public static string SanitizeLabel(this string label)
        {
            string s = new string(label.Replace(" ", "_").Where(IsAllowedInLabel).ToArray());
            if (char.IsDigit(s[0]))
                s = "_" + s;
            return s.ToLower();
        }

        public static bool IsAllowedInLabel(char c)
        {
            return char.IsLetterOrDigit(c) || c == '_';
        }
    }

    public class CodeStringBuilder
    {
        private StringBuilder _sb = new StringBuilder();

        public int IndentLevel = 0;
        public bool? NextCondition = null;
        public bool InIf = false;

        public CodeStringBuilder Indent()
        {
            IndentLevel++;
            return this;
        }

        public CodeStringBuilder UnIndent()
        {
            IndentLevel--;
            return this;
        }

        public CodeStringBuilder Append(string s)
        {
            _sb.Append(s);
            return this;
        }

        public CodeStringBuilder AppendLine(string line = "")
        {
            if (InIf)
            {
                _sb.AppendTabs(1);
                InIf = false;
            }
            if (NextCondition == null || NextCondition.Value)
            {
                _sb.AppendTabs(IndentLevel);
                _sb.AppendLine(line);
            }
            return this;
        }

        public CodeStringBuilder If(bool condition)
        {
            NextCondition = condition;
            return this;
        }

        public CodeStringBuilder EndIf()
        {
            NextCondition = null;
            return this;
        }

        public CodeStringBuilder AppendIf(string condition)
        {
            AppendLine($"if ({condition})");
            InIf = true;
            return this;
        }

        public CodeStringBuilder ForEach<T>(IEnumerable<T> enumerable, Func<T, string> func)
        {
            foreach (T t in enumerable)
                AppendLine(func(t));
            return this;
        }

        public override string ToString()
        {
            return _sb.ToString();
        }
    }
}
