using System.Collections.Generic;

namespace ClassLibraryNetCore.ManyToMany_With_Suplimentar_Info
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }

        public IList<DoctorPacient> DoctorPacients { get; set; }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Specialty: {Specialty}\n";
        }
    }
}
