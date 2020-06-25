Seq.initInfinite (fun _ -> System.Console.ReadLine())
|> Seq.takeWhile ((<>) null)
|> Seq.map (int >> abs)
|> Seq.iter(printfn "%d")