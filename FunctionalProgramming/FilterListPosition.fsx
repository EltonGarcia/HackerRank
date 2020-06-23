open System

let rec filterList list =
    match list with
    | _::x::xs -> x::filterList xs
    | _ -> []

[<EntryPoint>]
let main argv =
    let list =
        Seq.initInfinite(fun _ -> Console.ReadLine())
        |> Seq.takeWhile(String.IsNullOrEmpty >> not)
        |> Seq.toList
    List.iter (printfn("%s")) (filterList list)
    0