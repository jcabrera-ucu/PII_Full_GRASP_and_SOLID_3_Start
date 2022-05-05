using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public string Destino { get; }

        public FilePrinter(string destino)
        {
            Destino = destino;
        }

        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText(Destino, recipe.GetTextToPrint());
        }
    }
}