using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha26
{
    public static class MyExtensions
    {
        public static void  ExtensionRemover(this List<object> objetos)
        {
            foreach (var item in objetos.ToArray())
            {
                if (item is ITrashable)
                {
                    objetos.Remove(item);
                }
            }
            foreach (var item in objetos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
