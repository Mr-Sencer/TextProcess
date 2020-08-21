using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessingLib
{
    public struct SearchResult : IDisposable
    {
        //aranılan karakter :_char
        public char _char;
        public int İndex;
        public SearchResult(char c, int index, bool found)
        {
            _char = c;

            İndex = index;
            Found = found;
        }
        public bool Found;
        public void Dispose()
        {
            GC.SuppressFinalize(_char);
            GC.SuppressFinalize(İndex);
            GC.SuppressFinalize(this);
        }
    }
}
