module DifferenceOfSquares

type DifferenceOfSquares(number) =
    member this.SquareOfSums() =
        let sum = [1..number] |> List.sum
        pown sum 2

    member this.SumOfSquares() =
        [1..number]
        |> List.map (fun x -> pown x 2)
        |> List.sum

    member this.Difference() =
        this.SquareOfSums() - this.SumOfSquares()
