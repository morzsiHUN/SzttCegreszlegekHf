namespace SzttCegreszlegekHf
{
    // Biztosítja a feliratkozók számára a hibaüzenetek fogadását
    // és a küldőnek a feliratkozók tárolását
    interface IDepartmentError
    {
        void writeError( Department sender, List<ICompanyObject> companyObject);
    }
}
