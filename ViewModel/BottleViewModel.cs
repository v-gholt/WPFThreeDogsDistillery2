using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFThreeDogsDistillery2.Models;

namespace WPFThreeDogsDistillery2.ViewModel
{
    class BottleViewModel
    {
        private IList<Bottle> _BottlesList;

        public BottleViewModel()
        {
            _BottlesList = new List<Bottle>
            {
                new Bottle{Quantity = 1,Spirit="Brandy",Flavor="Cherry"},
            };
        }

        public IList<Bottle> Bottles
        {
            get { return _BottlesList; }
            set { _BottlesList = value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }
    }
}
