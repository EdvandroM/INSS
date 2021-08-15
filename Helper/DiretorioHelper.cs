using System;
using System.IO;
using System.Reflection;

namespace INSS.Helper
{
    public static class DiretorioHelper
    {
        public static string GetExecutingDirectoryName()
        {
            return Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        }
    }
}
