using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q521663 {
    public class ViewModel {
        public ViewModel() {
            Categories = new ObservableCollection<Category> {
                new Category("Category1",
                    new Page("Page1",
                        new Group("Group1",
                            new Item("Item1"),
                            new Item("Item2")
                        )),
                    new Page("Page2")
                )
            };

        }
        public ObservableCollection<Category> Categories { get; }
    }
    public class Category : ItemBase {
        public ObservableCollection<Page> Pages { get; }
        public Category(string name = null, params Page[] pages) : base(name) {
            Pages = new ObservableCollection<Page>(pages);
        }
    }
    public class Page : ItemBase {
        public ObservableCollection<Group> Groups { get; }
        public Page(string name = null, params Group[] groups) : base(name) {
            Groups = new ObservableCollection<Group>(groups);
        }
    }
    public class Group : ItemBase {
        public ObservableCollection<Item> Items { get; }
        public Group(string name = null, params Item[] items) : base(name) {
            Items = new ObservableCollection<Item>(items);
        }
    }
    public class Item : ItemBase {
        public Item(string name = null) : base(name) { }
    }
    public abstract class ItemBase : ViewModelBase {
        public string Name { get => GetValue<string>(); set => SetValue(value); }
        public ItemBase(string name) {
            Name = name;
        }
    }
}