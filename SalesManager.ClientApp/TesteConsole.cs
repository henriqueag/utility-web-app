using System;

namespace SistemaVendas
{
    public class TesteConsole
    {
        static void Main (String[] args)
        {
            if (args is null)
                throw new ArgumentNullException(nameof(args));
            
        }
    }
}