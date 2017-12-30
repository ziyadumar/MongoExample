using System.Threading.Tasks;
using Bubbles.Models;

namespace Bubbles.Interfaces {
    public interface IPuzzleRepository
    {
        Task Add(PuzzleData data);
    }
}