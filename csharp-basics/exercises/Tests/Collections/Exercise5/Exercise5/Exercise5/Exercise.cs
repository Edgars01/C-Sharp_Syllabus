using System.IO;

namespace Exercise5
{
    public class Exercise : IExercise
    {
        public int CharCountInFile(string text)
        {
            if (text == null) throw new FileNotFoundException();

            return text.Length;
        }

        public int LineCount(string text)
        {
            return text.Split('\n').Length;
        }

        public int WordCount(string text)
        {
            var word = 0;

            for (var i = 0; i <= text.Length - 1; i++)
                if (text[i] == ' ' || text[i] == '\n' || text[i] == '\t')
                    word++;

            return word;
        }
    }
}
