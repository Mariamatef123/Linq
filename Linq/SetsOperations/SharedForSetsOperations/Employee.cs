namespace SharedForSetsOperations
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"EmployeeId: {EmployeeId}, Name: {Name}";
        }
        //public override bool Equals(object? obj)
        //{
        //    if (obj is Employee other)
        //    {
        //        return this.EmployeeId == other.EmployeeId;
        //    }
        //    return false;
        //}
        public override int GetHashCode()
        {
            return EmployeeId.GetHashCode();
        }
    }
}