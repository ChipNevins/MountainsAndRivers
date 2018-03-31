using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMountainsAndRivers.Models
{
    public class River: ObservableObject
    {
        #region Fields

        string _riverId;
        string _riverName;
        int _milesLong;

        #endregion

        #region Property getters and setters
        public string RiverId
        {
            get { return _riverId; }
            set
            {
                if (value != _riverId)
                {
                    _riverId = value;
                    OnPropertyChanged("RiverId");
                }
            }
        }

        public string RiverName {
            get { return _riverName; }
            set
            {
                if (value != _riverName)
                {
                    _riverName = value;
                    OnPropertyChanged("RiverName");
                }
            }

        }

        public int MilesLong
        {
            get { return _milesLong; }
            set
            {
                if (value != _milesLong)
                {
                    _milesLong = value;
                    OnPropertyChanged("MilesLong");
                }
            }
        }
        #endregion Property getters and setters

        public River (string riverId, string riverName, int milesLong )
        {
            this._riverId = riverId;
            this._riverName = riverName;
            this._milesLong = milesLong;
        }

    }
}
