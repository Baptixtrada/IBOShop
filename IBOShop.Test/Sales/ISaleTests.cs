using IBOShop.Test.Common;

namespace IBOShop.Test.Sales
{
    public interface ISaleTests : ITests
    {
        void TestSetAndGetCustomer();
        void TestSetAndGetDate();
        void TestSetAndGetEmployee();
        void TestSetAndGetProduct();
    }
}