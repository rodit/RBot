using RBot.Flash;
using RBot.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RBot;

public class ScriptMonsters : ScriptableObject
{
    /// <summary>
    /// A list of cells to ignore when hunting enemies.
    /// </summary>
    public List<string> HuntCellBlacklist { get; } = new List<string>();
    /// <summary>
    /// A list of monsters in the current cell.
    /// </summary>
    public List<Monster> CurrentMonsters => MapMonsters.FindAll(m => m.Cell == Bot.Player.Cell);
    /// <summary>
    /// A list of all monsters in the current map.
    /// </summary>
    [ObjectBinding("world.monsters", Select = "objData")]
    public List<Monster> MapMonsters { get; }

    /// <summary>
    /// Checks whether the specified monster exists in the current cell.
    /// </summary>
    /// <param name="name">The name of the monster whose existence should be checked.</param>
    /// <returns>Whether the specified monster exists and is alive in the current cell.</returns>
    public bool Exists(string name) => CurrentMonsters.Find(m => name == "*" || m.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && m.Alive) != null;

    public bool TryGetMonster(string name, out Monster monster)
    {
        monster = CurrentMonsters.Find(m => name == "*" || m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        return monster != null;
    }

    /// <summary>
    /// Gets a dictionary which maps cell names of the current map to all monsters in that cell.
    /// </summary>
    public Dictionary<string, List<Monster>> GetCellMonsters()
    {
        Dictionary<string, List<Monster>> monsters = new();
        List<Monster> mapmons = new();
        foreach (string cell in Bot.Map.Cells)
            monsters[cell] = GetMonstersByCell(cell);
        return monsters;
    }

    /// <summary>
    /// Gets all of the monsters in the given cell in the current map.
    /// </summary>
    public List<Monster> GetMonstersByCell(string cell) => MapMonsters.FindAll(x => x.Cell == cell);

    /// <summary>
    /// Gets all of the cells with the desired monster in (in the current map).
    /// </summary>
    public List<string> GetMonsterCells(string monsterName) => MapMonsters.Where(m => m.Name.Equals(monsterName, StringComparison.OrdinalIgnoreCase) && !HuntCellBlacklist.Contains(m.Cell)).Select(m => m.Cell).Distinct().ToList();

    /// <summary>
    /// Gets all of the cells with a living instance of the desired monster (in the current map).
    /// </summary>
    public List<string> GetLivingMonsterCells(string monsterName) => MapMonsters.Where(m => m.Alive && (monsterName == "*" || m.Name.Equals(monsterName, StringComparison.OrdinalIgnoreCase)) && !HuntCellBlacklist.Contains(m.Cell)).Select(m => m.Cell).Distinct().ToList();
}
