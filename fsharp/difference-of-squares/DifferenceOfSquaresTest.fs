module DifferenceOfSquaresTests

open NUnit.Framework
open DifferenceOfSquares

[<TestFixture>]
type DifferenceOfSquaresTests() =

    [<Test>]
    member test.SquareOfSumsTo5() =
        Assert.That(DifferenceOfSquares(5).SquareOfSums(), Is.EqualTo(225))

    [<Test>]
    member test.SumOfSquaresTo5() =
        Assert.That(DifferenceOfSquares(5).SumOfSquares(), Is.EqualTo(55))

    [<Test>]
    member test.DifferenceOfSumsTo5() =
        Assert.That(DifferenceOfSquares(5).Difference(), Is.EqualTo(170))

    [<Test>]
    member test.SquareOfSumsTo10() =
        Assert.That(DifferenceOfSquares(10).SquareOfSums(), Is.EqualTo(3025))

    [<Test>]
    member test.SumOfSquaresTo10() =
        Assert.That(DifferenceOfSquares(10).SumOfSquares(), Is.EqualTo(385))

    [<Test>]
    member test.DifferenceOfSumsTo10() =
        Assert.That(DifferenceOfSquares(10).Difference(), Is.EqualTo(2640))

    [<Test>]
    member test.SquareOfSumsTo100() =
        Assert.That(DifferenceOfSquares(100).SquareOfSums(), Is.EqualTo(25502500))

    [<Test>]
    member test.SumOfSquaresTo100() =
        Assert.That(DifferenceOfSquares(100).SumOfSquares(), Is.EqualTo(338350))

    [<Test>]
    member test.DifferenceOfSumsTo100() =
        Assert.That(DifferenceOfSquares(100).Difference(), Is.EqualTo(25164150))
