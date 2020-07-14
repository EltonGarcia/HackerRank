open System

let fibonacci nth =
    let rec aux n1 n2 n =
        if n < nth then aux (n1+n2) n1 (n+1)
        else n1
    aux 0 1 1
    
[<EntryPoint>]
let main argv =
    let nth = Console.ReadLine() |> int
    printfn ("%d") (fibonacci nth)
    0