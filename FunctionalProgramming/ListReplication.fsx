open System
[<EntryPoint>]
let main argv = 
    let repeat = Console.ReadLine() |> int
    let list =
        Seq.initInfinite (fun _ -> Console.ReadLine())
        |> Seq.takeWhile(String.IsNullOrEmpty >> not)
        |> Seq.toList

    let replicate n = List.replicate repeat n
    List.iter (printfn "%s") (List.collect replicate list)
    0