/// Module in charge of handling SumOfMultiples
/// 
/// SumOfMultiples:
///     param: list : list -> int
///     Members:
///     To:
///         param: number : int
///         Return sum of multiples from this.list for given number.
///         If no list is given, 3 and 5 are used by default.
///
/// numberModuleInList:
///     param: number : int
///     param: list : list -> int
///     Return true if module of number and any value from list is 0, else false.
module SumOfMultiples

let rec numberModuleInList number list = 
    match list with
    | head :: rest when number % head = 0 -> true
    | head :: rest -> numberModuleInList number rest
    | [] -> false

type SumOfMultiples(?list) =
    member this.To number =
        let multipleList =
            match list with
            | l when Option.isNone l -> [3; 5]
            | _ -> list.Value

        let mutable total = 0
        for num in 1..number - 1 do
            if numberModuleInList num multipleList then
                total <- total + num
        total