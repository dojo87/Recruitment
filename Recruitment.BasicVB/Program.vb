Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Xunit

Namespace RecruitmentTests
    Module Program
        Sub Main(ByVal args As String())
            Dim any As New IndexOfAny()
            System.Console.WriteLine(any.Compute("Alice has a cat", New Char() {"s"c, "h"c}))
            System.Console.ReadLine()

        End Sub
    End Module

    Public Class IndexOfAny
        Public Function Compute(stringToSearch As String, charsToCheck As Char()) As Integer
            ' Implement the upper function without using the IndexOf... extension methods.
            ' Requirement: ------
            ' search the stringToSearch string for the first occurence of any of the given array of charsToCheck (case sensitive).
            ' If found, return the zero-based index of that char in the analyzed stringToSearch.
            ' If any of the chars is not found in the string, return -1. 
            ' e.g. Compute("Alice has a cat", New Char() { "s"c, "h"c }) will return 6 (h). 

            Return stringToSearch.IndexOfAny(charsToCheck)
        End Function
    End Class

    Public Class IndexOfAnyTestVB

        ' #1. Make the IndexOfAny implementation pass the test.
        <Fact>
        Public Sub TestComputeVB()
            Dim any As New IndexOfAny()
            Assert.Equal(6, any.Compute("Alice has a cat", New Char() {"s"c, "h"c}))
            Assert.Equal(7, any.Compute("Alice has a cat", New Char() {"b"c, "v"c, "r"c, "a"c}))
            ' case sensitive !
            Assert.Equal(-1, any.Compute("Alice has a cat", New Char() {"x"c, "y"c, "z"c}))
            Assert.Equal(4, any.Compute("Cat has a Alice", New Char() {"l"c, "h"c}))
        End Sub

        ' #2. Uncomment this test, and implement an extension method that will make use of the IndexOfAny implementation, so that it passes the test. 
        '[Fact]
        'public void TestComputeExtensionVB()
        '{
        '    Assert.Equal(6, "Alice has a cat".ComputeIndexOfAny(New Char() { "s"c, "h"c }));
        '    Assert.Equal(7, "Alice has a cat".ComputeIndexOfAny(New Char() { "b"c, "v"c, "r"c, "a"c })); // case sensitive !
        '    Assert.Equal(-1,"Alice has a cat".ComputeIndexOfAny(New Char() { "x"c, "y"c, "z"c }));
        '    Assert.Equal(4, "Cat has a Alice".ComputeIndexOfAny(New Char() { "l"c, "h"c }));
        '}
    End Class
End Namespace

