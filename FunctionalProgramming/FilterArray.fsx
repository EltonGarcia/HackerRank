open System

let filter n list = 
    let rec filterHelper l result =
        match l with
        | [] -> result |> List.rev
        | y::ys -> 
            if (y < n) 
            then filterHelper ys (y::result)
            else filterHelper ys result
    filterHelper list []

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    let list = 
        Seq.initInfinite (fun _ -> Console.ReadLine())
        |> Seq.takeWhile(String.IsNullOrEmpty >> not)
        |> Seq.map System.Int32.Parse
        |> Seq.toList

    List.iter (printfn("%d")) (filter n list)
    0