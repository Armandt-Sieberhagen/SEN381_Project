using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    class MedicalServiceProvider
    {
        Address address;
        List<MedicalPackage> packages;

        public Address MyAddress {
            get { return address; }
            set { address = value; }
        }
        public List<MedicalPackage> Packages {
            get { return packages; }
            set { packages = value; }
        }
    }
}
