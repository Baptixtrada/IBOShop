namespace IBOShop.Test.Sales
{
    public interface ICreateSaleTests
    {
        void SetUp();
        void TestExecuteShouldAddSaleToTheDatabase();
        void TestExecuteShouldNotifyInventoryThatSaleOccurred();
        void TestExecuteShouldSaveChangesToDatabase();
    }
}