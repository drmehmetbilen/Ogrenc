using Ogrenc.Business.ExtraClassesAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings;
using System.Text.Unicode;
using System.Text.Encodings.Web;


namespace Ogrenc.Business.ExtraClassesConcrete
{
    public class Functions : IFunctions
    {
        JsonSerializerOptions options;
        public Functions()
        {
            options = new JsonSerializerOptions(); options.Encoder = JavaScriptEncoder.Create(UnicodeRanges.All);

        }



        public string Serialize(object obj)
        {
          
            return JsonSerializer.Serialize(obj, options);
        }
    }
}
