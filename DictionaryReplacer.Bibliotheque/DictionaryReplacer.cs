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
            throw new NotImplementedException();
        }
    }
}
