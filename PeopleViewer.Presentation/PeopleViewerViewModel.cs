using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleViewer.Presentation
{
    public class PeopleViewerViewModel : INotifyPropertyChanged
    {
        protected ServiceRepository Repository;
        private IEnumerable<Person> _people;
        public IEnumerable<Person> People
        {
            get { return _people; }
            set
            {
                if (_people == value)
                    return;
                _people = value;
                RaisePropertyChanged("People");
            }
        }

        public PeopleViewerViewModel()
        {
            Repository = new ServiceRepository();
        }

        #region Commands

        #region RefreshCommand Standard Stuff
        #endregion RefreshCommand Standard Stuff

        public void Execute(object parameter)
        {
            ViewModel.People = ViewModel.Repository.GetPeople();
        }


        #region ClearCommand Standard Stuff
        public void Execute(object parameter)
        {
            ViewModel.People = new List<Person>();
        }

        #endregion ClearCommand Standard Stuff



        #endregion Commands

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string properyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion INotifyPropertyChanged Members

    }
}
