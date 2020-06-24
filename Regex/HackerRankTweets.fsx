open System
open System.Text.RegularExpressions

[<EntryPoint>]
let main argv =
    let n = Console.ReadLine() |> int

    let validate input = Regex.Match(input, "hackerrank", RegexOptions.IgnoreCase).Success
    let sentences = 
        seq { for _ in 1 .. n -> Console.ReadLine() }
        |> Seq.filter validate
        |> Seq.toList
        
    printfn("%d") sentences.Length
    0