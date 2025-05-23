using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CommonUtilities.Collections
{
    /// <summary>
    /// A BindingList that preserves a master list internally,
    /// and supports filtering and reset functionality.
    /// Can be used directly as a DataSource for a DataGridView.
    /// </summary>
    public class RbBindingList<T> : BindingList<T>
    {
        private readonly List<T> _masterList;

        /// <summary>
        /// Initializes a new instance wrapping the given items.
        /// </summary>
        public RbBindingList(IEnumerable<T> items)
            : base(ToList(items))
        {
            // 'Items' is the list we passed to base, so just clone it
            _masterList = new List<T>(Items);
        }

        private static IList<T> ToList(IEnumerable<T> items)
        {
            // Materialize once
            return items as IList<T> ?? items.ToList();
        }

        /// <summary>
        /// Replace the visible items with only those matching the predicate.
        /// </summary>
        public void ApplyFilter(Func<T, bool> predicate)
        {
            var filtered = _masterList.Where(predicate).ToList();

            RaiseListChangedEvents = false;
            Clear();
            foreach (var item in filtered)
                Add(item);
            RaiseListChangedEvents = true;
            ResetBindings();
        }

        /// <summary>
        /// Restores the original, unfiltered list.
        /// </summary>
        public void ResetFilter()
        {
            RaiseListChangedEvents = false;
            Clear();
            foreach (var item in _masterList)
                Add(item);
            RaiseListChangedEvents = true;
            ResetBindings();
        }
    }
}