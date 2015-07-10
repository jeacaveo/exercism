module Bob


type Bob(message:string) =
    member this.Hey() =
        match message with
        | x when message.EndsWith("?") -> "Sure."
        | x when x.Trim() = "" -> "Fine. Be that way!"
        | x when message.ToUpper() = message -> "Whoa, chill out!"
        | _ -> "Whatever."
