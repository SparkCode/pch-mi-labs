namespace Generics1
{
    public class Processor<TEngine, TEntity, TLogger>
    {
    }

    public class Processor
    {
        public static ProcessorBuilder<TEngine> CreateEngine<TEngine>()
            => new ProcessorBuilder<TEngine>();
    }
}