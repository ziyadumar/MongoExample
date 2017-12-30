using System;
using System.Threading.Tasks;
using Bubbles.Interfaces;
using Bubbles.Models;
using Bubbles.Services;
using MongoDB.Driver;

namespace Bubbles.Repository {
    public class PuzzleRepository: IPuzzleRepository {
        private MongoService _mongoService;
        private IMongoCollection<PuzzleData> _puzzleCollection;
        public PuzzleRepository(
            MongoService mongoService
        ) {
            _puzzleCollection = mongoService.GetDatabase().GetCollection<PuzzleData>("puzzleData");
        }

        public async Task Add(PuzzleData data) {
            await _puzzleCollection.InsertOneAsync(data);
        }

    }
}