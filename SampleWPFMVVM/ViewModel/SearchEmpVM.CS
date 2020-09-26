using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using SampleWPFMVVM.Entity; //namespace of Employee class

namespace SampleWPFMVVM.ViewModel
{
    class SearchEmpVM : INotifyPropertyChanged
    {
        readonly List<EmpCls> EmpList = new List<EmpCls>();

        public SearchEmpVM()
        {
            // Add sample employee details into employee list
            EmpList.Clear();
            EmpList.Add(new EmpCls { EmpNo = 1, Name = "John", Department = "IT", Designation = "Developer" });
            EmpList.Add(new EmpCls { EmpNo = 2, Name = "Mark", Department = "IT", Designation = "Tester" });
            EmpList.Add(new EmpCls { EmpNo = 3, Name = "Robert", Department = "IT", Designation = "DB Developer" });
        }

        #region properties

        private EmpCls _searchcls = new EmpCls();
        public EmpCls SearchCls
        {
            get { return _searchcls; }

            set
            {
                _searchcls = value;
                RaisePropertyChanged("SearchCls");
            }
        }

        private int _empid;
        public int EmpId
        {
            get
            {
                return _empid;
            }
            set
            {
                _empid = value;
                RaisePropertyChanged("EmpId");
                PopulteEmpDetails(_empid);
            }
        }

        #endregion

        private void PopulteEmpDetails(int _empid)
        {
            SearchCls = EmpList.Where(x => x.EmpNo == _empid).Single();
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
