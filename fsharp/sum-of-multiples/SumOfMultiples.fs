/// Module in charge of handling SumOfMultiples
///
/// SumOfMultiples:
///     param: divisors : list -> int (optional)
///     Members:
///     NumberModuleInList (private):
///         param: number : int
///         param: divisors : lits -> int
///         Return list -> int of numbers that are module 0 of number
///     To:
///         param: number : int
///         Return sum of multiples from this.list for given number.
///         If no list is given, 3 and 5 are used by default.
module SumOfMultiples


type SumOfMultiples(divisors) =
    member private this.NumberModuleInList number =
        divisors
        |> Seq.exists (fun num -> number % num = 0)

    member this.To number =
        [1..number-1]
        |> Seq.filter (fun num -> this.NumberModuleInList num)
        |> Seq.sum

    new() = SumOfMultiples([3; 5])