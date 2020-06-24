open System

let rev list =
    let rec reverse list result =
        match list with
        | [] -> result
        | x::xs -> reverse xs (x::result)
    reverse list []

[<EntryPoint>]
let main argv =
    let list =
        Seq.initInfinite(fun _ -> Console.ReadLine())
        |> Seq.takeWhile(String.IsNullOrEmpty >> not)
        |> Seq.toList
    List.iter (printfn("%s")) (rev list)
    0