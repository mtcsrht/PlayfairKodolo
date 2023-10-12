using System.IO;

namespace playfair
{
    internal class PlayfairKodolo
    {

        private readonly char[,] _matrix = new char[5,5];
        public PlayfairKodolo(string fileName)
        {
            using(var sr = new StreamReader($@"..\..\src\{fileName}"))
            {
                string line;
                int r = 0;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                        for (int c = 0; c < _matrix.GetLength(1); c++)
                        {
                            if (line != null) _matrix[r, c] = line[c];
                        }
                    r++;
                }
           
            }

        }
        public int SorIndex(char betu)
        {
            for (int r = 0; r < _matrix.GetLength(0); r++)
            {
                for (int c = 0; c < _matrix.GetLength(1); c++)
                {
                    if (_matrix[r,c] == betu)
                    {
                        return r;
                    }
                }
            }
            return -1;
        }
        public int OszlopIndex(char betu)
        {
            for (int r = 0; r < _matrix.GetLength(0); r++)
            {
                for (int c = 0; c < _matrix.GetLength(1); c++)
                {
                    if (_matrix[r, c] == betu)
                    {
                        return c;
                    }
                }
            }
            return -1;
        }

        public string KodolBetupar(string karakterek)
        {
            char[] c = karakterek.ToCharArray();

            char[] resolvedChars = new char[2];
            if (SorIndex(c[0]) == SorIndex(c[1]))
            {
                if (OszlopIndex(c[0]) == 4)
                {
                    resolvedChars[0] = _matrix[SorIndex(c[0]), 0];
                }
                else
                {
                    resolvedChars[0] = _matrix[SorIndex(c[0]), OszlopIndex(c[0]) + 1];
                }

                if (OszlopIndex(c[1]) == 4)
                {
                    resolvedChars[1] = _matrix[SorIndex(c[1]), 0];
                }
                else
                {
                    resolvedChars[1] = _matrix[SorIndex(c[1]), OszlopIndex(c[1]) + 1];
                }

            }
            else if (OszlopIndex(c[0]) == OszlopIndex(c[1]))
            {
                if (SorIndex(c[0]) == 4)
                {
                    resolvedChars[0] = _matrix[0, OszlopIndex(c[0])];
                }
                else
                {
                    resolvedChars[0] = _matrix[SorIndex(c[0]) + 1, OszlopIndex(c[0])];
                }
                
                if (SorIndex(c[1]) == 4)
                {
                    resolvedChars[1] = _matrix[0, OszlopIndex(c[1])];
                }
                else
                {
                    resolvedChars[1] = _matrix[SorIndex(c[1]) + 1, OszlopIndex(c[1])];
                }
          
            }
            else if (OszlopIndex(c[0]) != OszlopIndex(c[1]) && SorIndex(c[0]) != SorIndex(c[1]))
            {
                resolvedChars[0] = _matrix[SorIndex(c[0]), OszlopIndex(c[1])];
                resolvedChars[1] = _matrix[SorIndex(c[1]), OszlopIndex(c[0])];
            }
            return resolvedChars[0]+resolvedChars[1].ToString();
        }
    }
}
