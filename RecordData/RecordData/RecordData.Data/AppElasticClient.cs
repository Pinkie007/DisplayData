using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordData.Data
{
    public class AppElasticClient : ElasticClient
    {
        public AppElasticClient() : base(new ConnectionSettings(new Uri("http://localhost:9200")).DefaultIndex("values")) 
    {
       
     }
    }
}