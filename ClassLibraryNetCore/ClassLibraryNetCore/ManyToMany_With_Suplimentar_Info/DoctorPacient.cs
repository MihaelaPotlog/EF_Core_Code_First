using System;

namespace ClassLibraryNetCore.ManyToMany_With_Suplimentar_Info
{
    public class DoctorPacient
    {
        public int DoctorId { get; set; }
        public int PacientId { get; set; }
        public DateTime StartDate { get; set; }

        public Doctor Doctor { get; set; }
        public Pacient Pacient { get; set; }

    }
}
