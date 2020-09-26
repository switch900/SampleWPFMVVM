namespace SampleWPFMVVM.Entity
{
    class EmpCls
    {
        private int _empNo;
        public int EmpNo
        {
            get { return _empNo; }
            set
            {
                _empNo = value;
            }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;

            }
        }
        private string _designation;
        public string Designation
        {
            get { return _designation; }
            set
            {
                _designation = value;
            }
        }
        private string _department;
        public string Department
        {
            get { return _department; }
            set
            {
                _department = value;
            }
        }
    }
}
//