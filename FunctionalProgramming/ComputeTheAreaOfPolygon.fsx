open System

type Point = { X: float; Y: float }

let shoelace a b = ((a.X * b.Y) - (b.X * a.Y))
    
let calcPolygonArea (points: List<Point>) =
    let head = points.Head
    let rec calc pts area =
        match pts with
        | [] -> area
        | a::b::xs -> calc (b::xs) ((shoelace a b) + area)
        | a::xs -> calc xs ((shoelace a head) + area)
    (calc points 0.0) / 2.0

[<EntryPoint>]
let main argv =
    let points = Console.ReadLine() |> int
    let list = 
        Seq.initInfinite (fun _ -> Console.ReadLine())
        |> Seq.takeWhile(String.IsNullOrEmpty >> not)
        |> Seq.map (fun o -> o.Split [|' '|] |> Array.map (float)) 
        |> Seq.toList
        |> List.map (fun item -> { X = item.[0]; Y = item.[1] })
    let area = calcPolygonArea list
    printfn ("%f") area
    0