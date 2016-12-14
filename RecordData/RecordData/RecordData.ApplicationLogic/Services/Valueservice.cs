using RecordData.ApplicationLogic.Interfaces;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordData.Data;

namespace RecordData.ApplicationLogic.Services
{
    public class ValueService : IValueService
    {
        private readonly IElasticClient _elasticClient;

        public ValueService(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public IEnumerable<int> GetValues()
        {
            return _elasticClient.Search<ValueModel>(s => s.MatchAll())
                .Hits
                .Select(h => h.Source.Value);
        }

        public string AddValue(int value)
        {
            var id = Guid.NewGuid();
            var valueModel = new ValueModel
            {
                Id = id,
                Value = value

            };
            _elasticClient.Index(valueModel);
            return id.ToString();
        }
        public int? GetValue(Guid id)
        {
            var elasticResponse = _elasticClient.Get<ValueModel>(id);
            return elasticResponse.Source?.Value;

        }

    }
}