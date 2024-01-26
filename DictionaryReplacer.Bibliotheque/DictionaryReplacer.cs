namespace DictionaryReplacer.Bibliotheque
{
    public class DictionaryReplacer
    {
        public string Replace(string input, Dictionary<string, string> dictionary)
        {
            if (input == "" || dictionary == null || dictionary.Count == 0)
            {
                return input;
            }

            foreach (var entry in dictionary)
            {
                string motentree = entry.Key;
                string sortiedictionnaire = entry.Value;
                input = input.Replace($"${motentree}$", sortiedictionnaire);
            }

            return input;
        }
    }
}
