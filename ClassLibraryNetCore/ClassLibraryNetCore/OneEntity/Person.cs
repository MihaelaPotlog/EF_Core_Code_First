namespace ClassLibraryNetCore
{
    public  class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        public override string ToString()
        {
            return $"FirstName:{FirstName} MiddleName: {MiddleName}  LastName: {LastName} TelephoneNr: {TelephoneNumber}\n\n";
        }
    }
    
}
