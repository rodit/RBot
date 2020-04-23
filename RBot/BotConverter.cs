using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;

namespace RBot
{
    public class BotConverter
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

            return "";
        }
    }
}
