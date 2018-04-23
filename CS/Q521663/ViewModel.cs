using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q521663
{
    public class ViewModel
    {
        public ViewModel()
        {
            ObservableCollection<ItemBase> items = new ObservableCollection<ItemBase>();
            items.Add(new ItemBase() { Name = "Item1" });
            items.Add(new ItemBase() { Name = "Item2" });

            ObservableCollection<Group> groups = new ObservableCollection<Group>();
            groups.Add(new Group() { Name = "Group1", Items = items });

            ObservableCollection<Page> pages = new ObservableCollection<Page>();
            pages.Add(new Page() { Name = "Page1", Groups = groups });
            pages.Add(new Page() { Name = "Page2"});

            Categories = new ObservableCollection<Category>();
            Categories.Add(new Category() { Name = "Category1", Pages = pages });

        }
        public ObservableCollection<Category> Categories
        {
            get;
            set;
        }
    }
    public class Category : ItemBase
    {
        public ObservableCollection<Page> Pages
        {
            get;
            set;
        }
    }
    public class Page : ItemBase
    {
        public ObservableCollection<Group> Groups
        {
            get;
            set;
        }
    }
    public class Group : ItemBase
    {
        public ObservableCollection<ItemBase> Items
        {
            get;
            set;
        }
    }
    public class ItemBase
    {
        public string Name
        {
            get;
            set;
        }
    }
}
