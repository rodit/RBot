using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RBot.Options
{
    public class OptionContainer
    {
        /// <summary>
        /// A list of the container's option definitions.
        /// </summary>
        public List<IOption> Options { get; } = new List<IOption>();

        /// <summary>
        /// A dictionary containing lists of options paired with a category name.
        /// </summary>
        public Dictionary<string, List<IOption>> MultipleOptions { get; } = new Dictionary<string, List<IOption>>();

        /// <summary>
        /// The mapping of the container's option definitions to their values.
        /// </summary>
        public Dictionary<IOption, string> OptionValues { get; } = new Dictionary<IOption, string>();
        /// <summary>
        /// Defines the location that the option's for this container are saved to and loaded from.
        /// </summary>
        public virtual string OptionsFile { get; set; }

        /// <summary>
        /// Sets this plugins options to the default values. This does not save the options.
        /// </summary>
        public void SetDefaults()
        {
            Options.ForEach(o => OptionValues[o] = o.DefaultValue.ToString());
            foreach(KeyValuePair<string, List<IOption>> kvp in MultipleOptions)
                foreach(IOption option in kvp.Value)
                    OptionValues[option] = option.DefaultValue.ToString();
        }

        /// <summary>
        /// Gets the option with the given name's value.
        /// </summary>
        /// <typeparam name="T">The type to return the value as.</typeparam>
        /// <param name="name">The name of the option.</param>
        /// <returns>The value of the option converted from a string to type T.</returns>
        public T Get<T>(string name) where T : IConvertible
            => Get<T>(Options.Find(o => o.Name == name));

        /// <summary>
        /// Gets the option from the specified category in <see cref="MultipleOptions"/>
        /// </summary>
        /// <typeparam name="T">The type to return the value as.</typeparam>
        /// <param name="category">The name of the option category.</param>
        /// <param name="name">The name of the option.</param>
        /// <returns></returns>
        public T Get<T>(string category, string name) where T : IConvertible
            => Get<T>(MultipleOptions[category].Find(o => o.Name == name));


        /// <summary>
        /// Gets the option's value.
        /// </summary>
        /// <typeparam name="T">The type to return the value as.</typeparam>
        /// <param name="option">The option.</param>
        /// <returns>The value of the option converted from a string to type T.</returns>
        public T Get<T>(IOption option) where T : IConvertible
        {
            return option == null ? default : OptionValues.TryGetValue(option, out string val) ? (typeof(T).IsEnum ? (T)Enum.Parse(typeof(T), val) : (T)Convert.ChangeType(val, typeof(T))) : default;
        }

        /// <summary>
        /// Gets the option's value directly as a string.
        /// </summary>
        /// <param name="option">The option.</param>
        /// <returns>The option's value as a string.</returns>
        public string GetDirect(IOption option)
            => OptionValues[option];

        /// <summary>
        /// Sets the option with the given name to the given value.
        /// </summary>
        /// <param name="name">The name of the option.</param>
        /// <param name="value">The value to set the option to.</param>
        public void Set(string name, object value)
            => Set(Options.Find(o => o.Name == name), value);

        /// <summary>
        /// Sets the option from <see cref="MultipleOptions"/> to the given value
        /// </summary>
        /// <param name="container">The category name of the option.</param>
        /// <param name="name">The name of the option.</param>
        /// <param name="value">The value to set the option to.</param>
        public void Set(string container, string name, object value)
            => Set(MultipleOptions[container].Find(o => o.Name == name), value);

        /// <summary>
        /// Sets the option to the given value of the given type.
        /// </summary>
        /// <typeparam name="T">The type of the value the option is being set to.</typeparam>
        /// <param name="option">The option.</param>
        /// <param name="value">The value to set the option to.</param>
        public void Set<T>(IOption option, T value)
        {
            OptionValues[option] = value.ToString();
            if (!option.Transient)
                Save();
        }

        /// <summary>
        /// Loads options from the container's options file, if it exists.
        /// </summary>
        public void Load()
        {
            if (File.Exists(OptionsFile))
            {
                foreach (string line in File.ReadLines(OptionsFile))
                {
                    string[] parts = line.Trim().Split(new char[] { ':', '=' }, 3);
                    if (parts.Length == 3)
                    {
                        IOption option = parts[0] switch
                        {
                            "Options" => Options.Find(o => o.Name == parts[1]),
                            _ => MultipleOptions[parts[0]].Find(o => o.Name == parts[1]),
                        };
                        if (option != null)
                            OptionValues[option] = parts[2];
                    }
                    if(parts.Length == 2)
                    {
                        IOption option = Options.Find(o => o.Name == parts[0]);
                        if (option != null)
                            OptionValues[option] = parts[1];
                    }
                }
            }
        }

        /// <summary>
        /// Saves all non-transient options of this container's plugin to its options file.
        /// </summary>
        /// <remarks>This will overwrite previous options.</remarks>
        public void Save()
        {
            List<string> linesToSave = new List<string>();
            linesToSave.AddRange(Options.Where(o => !o.Transient).Select(o => $"Options:{o.Name}={OptionValues[o]}"));
            foreach (KeyValuePair<string, List<IOption>> item in MultipleOptions)
                linesToSave.AddRange(item.Value.Where(o => !o.Transient).Select(o => $"{item.Key}:{o.Name}={OptionValues[o]}"));

            File.WriteAllLines(OptionsFile, linesToSave);
        }
    }
}
