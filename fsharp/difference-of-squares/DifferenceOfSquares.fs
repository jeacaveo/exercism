module DifferenceOfSquares

type DifferenceOfSquares(limit) =
    let numbers = [1..limit]

    member private this.IntPowTwo num =
        pown num 2

    member this.SquareOfSums() =
        numbers
        |> List.sum
        |> this.IntPowTwo

    member this.SumOfSquares() =
        numbers
        |> List.map this.IntPowTwo
        |> List.sum

    member this.Difference() =
        this.SquareOfSums() - this.SumOfSquares()
