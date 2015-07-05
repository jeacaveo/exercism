module SumOfMultiplesTest

open NUnit.Framework
open SumOfMultiples

[<TestFixture>]
type SumOfMultiplesTest() =
    let mutable sumOfMultiples = SumOfMultiples()
    
    [<Test>]
    member tc.SumTo1() = 
        Assert.That(sumOfMultiples.To(0), Is.EqualTo(0))

    [<Test>]
    member tc.SumTo3() = 
        Assert.That(sumOfMultiples.To(3), Is.EqualTo(0))

    [<Test>]
    member tc.SumTo10() = 
        Assert.That(sumOfMultiples.To(10), Is.EqualTo(23))

    [<Test>]
    member tc.Configurable71317To20() = 
        Assert.That(SumOfMultiples([7; 13; 17]).To(20), Is.EqualTo(51))

    [<Test>]
    member tc.Configurable4347To10000() = 
        Assert.That(SumOfMultiples([43; 47]).To(10000), Is.EqualTo(2203160))