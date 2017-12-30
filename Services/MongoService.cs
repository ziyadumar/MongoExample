using Bubbles.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Bubbles.Services {
    public class MongoService {
        private ConfigurationModel _options;
        private IMongoDatabase _db;
        private MongoClient _client;
        public MongoService(
            IOptions<ConfigurationModel> options
        ) {
            _options = options.Value;
            _client = new MongoClient(_options.MongoConnectionString);
            _db = _client.GetDatabase(_options.DatabaseName);
        }

        public IMongoDatabase GetDatabase() {
            return _db;
        }
    }
}