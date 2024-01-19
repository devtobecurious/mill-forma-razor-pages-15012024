namespace StarWars.Games.Core.Interfaces
{
    public interface IAddOne<T> where T : class
    {
        void Add(T item);
    }
}
