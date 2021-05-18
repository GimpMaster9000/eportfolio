using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace eportfolioWorkingSample
{
    public static class ConstantsAndParams
    {
        private static string _filePath;
        public static string FilePath
        {
            get 
            { 
                if(_filePath != null) return _filePath;
                else
                {
                    var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var addition = @"..\..\Database\Database1.accdb";
                    _filePath = Path.Combine(path, addition);
                    return _filePath;
                }
            }
            set { _filePath = value; }
        }

    }
}
