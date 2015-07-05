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
///     Return number if module of number and any value from list is 0, else 0.
module SumOfMultiples

let rec numberModuleInList number list =
    match list with
    | head :: rest when number % head = 0 -> number
    | head :: rest -> numberModuleInList number rest
    | [] -> 0

type SumOfMultiples(?list) =
    member this.To number =
        // Use default list if ?list not provided,
        // else use value of ?list (type list -> int)
        let multipleList =
            match list with
            | l when Option.isNone l -> [3; 5]
            | _ -> list.Value

        // Sum all items in list with multiple in multipleList.
        let rec sumMultiples list =
            match list with
            | head :: rest ->
                 numberModuleInList head multipleList + (sumMultiples rest)
            | [] -> 0

        // Use all postive numbers below given value.
        sumMultiples [1..number - 1]