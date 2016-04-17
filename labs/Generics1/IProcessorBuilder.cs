namespace Generics1
{
    public interface IProcessorBuilder<TEngine>
    {
        IProcessorBuilder<TEngine, TEntity> For<TEntity>();
    }

    public interface IProcessorBuilder<TEngine, TEntity>
    {
        Processor<TEngine, TEntity, TLogger> With<TLogger>();
    }
}