using Cecs475.Scheduling.Model;
using System.Collections.Generic;
using System.ComponentModel;

namespace Cecs475.Scheduling.RegistrationApp {

    public class SemesterTermDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() { return Name; }
    }

    public class CourseSectionDto {
        public int Id { get; set; }
        public int SemesterTermId { get; set; }
        public CatalogCourse CatalogCourse { get; set; }
        public int SectionNumber { get; set; }

        public override string ToString() {
            string secNum = string.Format("{0}", SectionNumber.ToString().PadLeft(2, '0'));
            return CatalogCourse.DepartmentName + " " + CatalogCourse.CourseNumber + "-" + secNum;
        }
    }

    public class RegistrationViewModel : INotifyPropertyChanged {
        public string ApiUrl { get; set; }
        public string FullName { get; set; }

        private IEnumerable<SemesterTermDto> mStdList;
        public IEnumerable<SemesterTermDto> StdList {
            get { return mStdList; }
            set {
                mStdList = value;
                OnPropertyChanged(nameof(StdList));
            }
        }

        private IEnumerable<CourseSectionDto> mCsdList;
        public IEnumerable<CourseSectionDto> CsdList {
            get { return mCsdList; }
            set {
                mCsdList = value;
                OnPropertyChanged(nameof(CsdList));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
