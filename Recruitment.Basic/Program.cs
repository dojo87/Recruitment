using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RecruitmentTests
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexOfAny any = new IndexOfAny();
            System.Console.WriteLine(any.Compute("Alice has a cat", new char[] { 's', 'h' }));
            System.Console.ReadLine();
        }
    }

    public class IndexOfAny
    {
        public int Compute(string stringToSearch, char[] charsToCheck)
        {
            // Implement the upper function without using the IndexOf... extension methods.
            // Requirement: ------
            // search the stringToSearch string for the first occurence of any of the given array of charsToCheck (case sensitive).
            // If found, return the zero-based index of that char in the analyzed stringToSearch.
            // If any of the chars is not found in the string, return -1. 
            // e.g. Compute("Alice has a cat", new char[] { 's', 'h' }) will return 6 (h). 

            return stringToSearch.IndexOfAny(charsToCheck);
        }
    }

    public class IndexOfAnyTest
    {

        // #1. Make the IndexOfAny implementation pass the test.
        [Fact]
        public void TestCompute()
        {
            IndexOfAny any = new IndexOfAny();
            Assert.Equal(6, any.Compute("Alice has a cat", new char[] { 's', 'h' }));
            Assert.Equal(7, any.Compute("Alice has a cat", new char[] { 'b','v','r','a' })); // case sensitive !
            Assert.Equal(-1, any.Compute("Alice has a cat", new char[] { 'x', 'y', 'z' }));
            Assert.Equal(4, any.Compute("Cat has a Alice", new char[] { 'l', 'h' }));
        }

        // #2. Uncomment this test, and implement an extension method that will make use of the IndexOfAny implementation, so that it passes the test. 
        //[Fact]
        //public void TestComputeExtension()
        //{
        //    Assert.Equal(6, "Alice has a cat".ComputeIndexOfAny(new char[] { 's', 'h' }));
        //    Assert.Equal(7, "Alice has a cat".ComputeIndexOfAny(new char[] { 'b', 'v', 'r', 'a' })); // case sensitive !
        //    Assert.Equal(-1,"Alice has a cat".ComputeIndexOfAny(new char[] { 'x', 'y', 'z' }));
        //    Assert.Equal(4, "Cat has a Alice".ComputeIndexOfAny(new char[] { 'l', 'h' }));
        //}
    }
}
