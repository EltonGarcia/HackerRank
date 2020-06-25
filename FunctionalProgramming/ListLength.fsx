open System

let count list =
    let rec countList list acc =
        match list with
        | [] -> acc
        | x::xs -> countList xs acc + 1
    countList list 0

[<EntryPoint>]
let main argv =
    let list =
        Seq.initInfinite(fun _ -> Console.ReadLine())
        |> Seq.takeWhile(String.IsNullOrEmpty >> not)
        |> Seq.toList
    printfn("%d") (count list)
    0