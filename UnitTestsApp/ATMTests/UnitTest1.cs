using System;
using Xunit;
using UnitTestsApp;


namespace ATMTests
{
    public class UnitTest1

    {
        
        [Fact]
        public void CanReturnBalance()
        {
            decimal getBalance = Program.ViewBalance();
            Assert.Equal(getBalance, Program.ViewBalance());
        }


        [Fact]
        public void CanNotReturnNegative()
        {
            Assert.NotEqual(-1, Program.ViewBalance());
        }

        [Fact]
        public void CorrectDeposit()
        {
            decimal getBalance = Program.ViewBalance();
            decimal result = getBalance + 1000;
            Assert.Equal(result, Program.Deposit(1000));
        }

        [Fact]
        public void IncorrectDeposit()
        {
            decimal getBalance = Program.ViewBalance();
            decimal result = getBalance ;

            Assert.NotEqual(result, Program.Deposit(100));
           
        }

        [Fact]
        public void CorrectWithdraw()
        {
            Program.Deposit(500);
            decimal getBalance = Program.ViewBalance();
            decimal result = getBalance - 50;

            Assert.Equal(result, Program.WithDraw(50));
        }

        [Fact]
        public void IncorrectWithdraw()
        {
            Program.Deposit(500);
            decimal getBalance = Program.ViewBalance();
            decimal result = getBalance;

            Assert.NotEqual(result, Program.WithDraw(100));

        }



    }
}
