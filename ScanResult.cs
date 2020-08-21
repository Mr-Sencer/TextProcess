   public struct SearchResult : IDisposable
    {
        //aranılan karakter :_char
        public char _char;
       // bulunan karakterin konumunu verir :İndex
       public int İndex;
        public SearchResult(char c, int index, bool found)
        {
            _char = c;

            İndex = index;
            Found = found;
        }
      // karakterin bulunup bulunmadığını gösterir :Found
      public bool Found;
        public void Dispose()
        {
            GC.SuppressFinalize(_char);
            GC.SuppressFinalize(İndex);
            GC.SuppressFinalize(this);
        }
    }
