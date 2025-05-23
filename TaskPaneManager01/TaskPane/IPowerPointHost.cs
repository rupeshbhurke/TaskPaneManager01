namespace TaskPaneManager01.TaskPane
{
    public interface IPowerPointHost
    {
        /// <summary>Inject the shared PPT context.</summary>
        void Initialize(IPowerPointContext context);
    }
}