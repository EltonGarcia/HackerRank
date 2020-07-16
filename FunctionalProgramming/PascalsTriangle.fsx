open System

let createLine prev  =
    [
        yield 1
        for (f, s) in Seq.pairwise prev do yield f + s
        yield 1
    ]

let pascalTriagle n =
    let top = [1]
    let rec build prev i =
        [if i < n then
            let line = createLine prev
            yield line
            yield! build line (i+1)
        ]
    [yield top; yield! (build top 1)]

[<EntryPoint>]
let main argv =
    let level = Console.ReadLine() |> int
    pascalTriagle level
        |> List.map (fun line -> printfn ("%s") (String.Join(' ', line |> List.map (string)))) |> ignore
    0