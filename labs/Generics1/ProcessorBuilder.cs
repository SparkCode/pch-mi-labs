namespace Generics1
{
    public class ProcessorBuilder<TEngine, TEntity> : IProcessorBuilder<TEngine, TEntity>
    {
        public Processor<TEngine, TEntity, TLogger> With<TLogger>() 
            => new Processor<TEngine, TEntity, TLogger>();
    }

    public class ProcessorBuilder<TEngine> : IProcessorBuilder<TEngine>
    {
        public IProcessorBuilder<TEngine, TEntity> For<TEntity>() 
            => new ProcessorBuilder<TEngine, TEntity>();
    }
}