module Bob

open System.Text.RegularExpressions

type Bob(message:string) =
    member private this.IsShout() =
        (message.ToUpper() = message && Regex.IsMatch(message, "[a-zA-Z]"))

    member this.Hey() =
        match message with
        | x when x.Trim() = "" -> "Fine. Be that way!"
        | x when this.IsShout() -> "Whoa, chill out!"
        | x when message.EndsWith("?") -> "Sure."
        | _ -> "Whatever."
