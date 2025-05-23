namespace TaskPaneManager01.TaskPane
{
    public interface ITaskPaneAware
    {
        /// <summary>
        /// Called whenever the pane is shown or hidden.
        /// </summary>
        /// <param name="visible">true if the pane is now visible.</param>
        void OnToggle(bool visible);
    }
}