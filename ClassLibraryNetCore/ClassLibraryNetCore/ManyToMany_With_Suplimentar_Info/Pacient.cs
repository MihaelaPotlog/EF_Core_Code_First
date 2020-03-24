using System.Collections.Generic;

namespace ClassLibraryNetCore.ManyToMany_With_Suplimentar_Info
{
    public class Pacient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public IList<DoctorPacient> DoctorPacients { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Age: {Age}\n";
        }
    }
}