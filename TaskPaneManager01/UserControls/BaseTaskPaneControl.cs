using System;
using System.Windows.Forms;
using TaskPaneManager01.TaskPane;

namespace TaskPaneManager01.UserControls
{
    public partial class BaseTaskPaneControl : UserControl, IPowerPointHost, ITaskPaneAware
    {
        protected IPowerPointContext Context;

        protected BaseTaskPaneControl()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public virtual void Initialize(IPowerPointContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public virtual void OnToggle(bool visible)
        {
            throw new NotImplementedException();
        }
    }
}
