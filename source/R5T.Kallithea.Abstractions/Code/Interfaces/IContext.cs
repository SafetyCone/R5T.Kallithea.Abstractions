using System;


namespace R5T.Kallithea
{
    public interface IContext
    {
        void Add(string key, object value);
        object Get(string key);
        bool Exists(string key);
        void Set(string key, object value);
        bool Remove(string key);
    }
}
