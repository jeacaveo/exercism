module SumOfMultiples

// Validate if module for number is in given list
let rec numberModuleInList number list = 
    match list with
    | head :: rest when number % head = 0 -> true
    | head :: rest -> numberModuleInList number rest
    | [] -> false

// Record with optional parameter
type SumOfMultiples(?list) =
    member this.To number =
        // scope is lost after if/else condition
        // "casting" given list parameter from Some to int list
        let mutable multipleList = []
        if Option.isNone list then
            multipleList <- [3; 5]
        else
            multipleList <- list.Value

        let mutable total = 0
        for i in 1..number - 1 do
            let isMultiple = numberModuleInList i multipleList
            if isMultiple then
                total <- total + i
        total 