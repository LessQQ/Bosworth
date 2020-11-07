using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Nottingham;
using Nottingham.Shire;

namespace Bosworth
{
    public class BosworthDocument
    {
        private ShireDB shireDB { get; set; }
        private string FileName { get; set; }

        public BosworthDocument(string fileName = "default.bos")
        {
            FileName = fileName;
            shireDB = new ShireDB(FileName);
        }
    }
}
