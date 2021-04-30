using Guiuiui.Common.Controls;
using Guiuiui.Common.RuntimeChecks;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Guiuiui.WinForms.Controls
{
    public class ListViewAdapter<TListItem> : IListControlAdapter<TListItem>
    {
        private readonly ListView listView;

        public ListViewAdapter(ListView listView)
        {
            ArgumentChecks.AssertNotNull(listView, nameof(listView));

            this.listView = listView;
        }

        public IReadOnlyList<TListItem> SelectedItems => throw new NotImplementedException();

        public event EventHandler SelectedItemsChanged;

        public void SetListItemsToDisplay(IReadOnlyList<TListItem> items)
        {
            throw new NotImplementedException();
        }

        public void SelectListItems(IEnumerable<TListItem> items)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
