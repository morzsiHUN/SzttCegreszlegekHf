namespace SzttCegreszlegekHf
{
    // A composity minta közös interfésze
    // ami lehetővé teszi, hogy egymást tárolják és a fa szerú struktúra felépítését
    interface ICompanyObject
    {
        string Name { get; set; }
        int EmployeeCount { get; }

        void List();
    }
}
