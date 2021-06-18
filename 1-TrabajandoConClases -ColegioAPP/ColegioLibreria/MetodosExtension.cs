using System;

namespace ColegioLibreria
{
    public static class MetodosExtension
    {
        public static int ContadorPalabras(this string palabras)
        {
            var    contadorPalabras = palabras.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return contadorPalabras;
        }
    }
}
