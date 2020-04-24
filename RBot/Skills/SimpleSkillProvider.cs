using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using RBot.Flash;
using RBot.Skills.UseRules;

namespace RBot.Skills
{
    public class SimpleSkillProvider : ISkillProvider
    {
        public bool CanSerialize => true;

        public List<SimpleSkill> Skills { get; } = new List<SimpleSkill>();
        public int Delay { get; set; } = 100;

        private int cIndex = 0;

        public bool ShouldUseSkill(ScriptInterface bot)
        {
            return Skills.Any(s => s.Rule.ShouldUse(bot));
        }

        public int GetNextSkill(ScriptInterface bot, out SkillMode mode)
        {
            if (cIndex >= Skills.Count)
                cIndex = 0;
            SimpleSkill skill = Skills[cIndex];
            cIndex++;
            mode = SkillMode.Optimistic;
            return skill.Index;
        }

        public void OnTargetReset(ScriptInterface bot)
        {

        }

        public void Stop(ScriptInterface bot)
        {
            cIndex = 0;
        }

        public void Load(string file)
        {
            Skills.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            if (int.TryParse(doc.DocumentElement.GetAttribute("delay"), out int i))
                Delay = i;
            foreach (XmlElement node in doc.GetElementsByTagName("skill"))
            {
                SimpleSkill skill = new SimpleSkill();
                skill.LoadXml(node);
                Skills.Add(skill);
            }
        }

        public void Save(string file)
        {
            using (XmlWriter writer = XmlWriter.Create(file, new XmlWriterSettings
            {
                IndentChars = "\t",
                OmitXmlDeclaration = true,
                NewLineOnAttributes = true
            }))
            {
                writer.WriteStartElement("skills");
                writer.WriteAttributeString("delay", Delay.ToString());
                foreach (SimpleSkill skill in Skills)
                    skill.SaveXml(writer);
                writer.WriteEndElement();
            }
        }
    }

    public class SimpleSkill
    {
        private static Dictionary<string, string> _legacyRuleMap = new Dictionary<string, string>()
        {
            { "RBot.HealthUseRule", "RBot.Skills.UseRules.HealthUseRule" },
            { "RBot.ManaUseRule", "RBot.Skills.UseRules.ManaUseRule" },
            { "RBot.CombinedUseRule", "RBot.Skills.UseRules.CombinedUseRule" }
        };

        public int Index { get; set; }
        public string Name => $"{Index}: {ScriptInterface.Instance.Player.Skills?[Index].Name ?? "Skills not loaded"}";
        public UseRule Rule { get; set; }

        public void LoadXml(XmlElement e)
        {
            if (int.TryParse(e.GetAttribute("index"), out int index))
                Index = index;
            string rtype = e.GetAttribute("rule");
            if (_legacyRuleMap.TryGetValue(rtype, out string type))
                rtype = type;
            Type t = Type.GetType(rtype);
            Rule = (UseRule)Activator.CreateInstance(t);
            Rule.LoadXml((XmlElement)e.FirstChild);
        }

        public void SaveXml(XmlWriter writer)
        {
            writer.WriteStartElement("skill");
            writer.WriteAttributeString("index", Index.ToString());
            writer.WriteAttributeString("rule", Rule.GetType().FullName);
            writer.WriteStartElement("rule");
            writer.WriteAttributeString("type", Rule.GetType().FullName);
            Rule.SaveXml(writer);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
