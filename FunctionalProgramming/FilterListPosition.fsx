open System

[<EntryPoint>]
let main argv =
    let list =
        Seq.initInfinite(fun index -> (index, Console.ReadLine()))
        |> Seq.takeWhile((fun (index, item) -> String.IsNullOrEmpty(item)) >> not)
        |> Seq.filter(fun (index, item) -> index % 2 <> 0)
        |> Seq.map(fun (index, item) -> item)
    Seq.iter (printfn("%s")) (list)
    0