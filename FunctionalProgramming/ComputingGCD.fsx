open System

let rec gcd values =
    match values with
    | (x, y) when x < y -> gcd (x - y, y)
    | (x, y) when x > y -> gcd (y - x, x)
    | (x, _) -> x

[<EntryPoint>]
let main argv =
    let arr = 
        Console.ReadLine().Split[|' '|] 
        |> (Array.map int)
    let values = (arr.[0], arr.[1])
    printfn("%d") (gcd values)
    0