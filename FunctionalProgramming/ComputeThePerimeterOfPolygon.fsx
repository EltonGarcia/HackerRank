open System

type Point = { X: float; Y: float }

let distanceBetweenPoints a b =
    sqrt ((a.X - b.X) ** 2.0 + (a.Y - b.Y) ** 2.0)

let calcPolygonPerimeter (points: List<Point>) =
    let head = points.Head
    let rec calc pts perimeter =
        match pts with
        | [] -> perimeter
        | x::y::xs -> calc (y::xs) (perimeter + distanceBetweenPoints x y)
        | x::xs -> calc xs perimeter + (distanceBetweenPoints x head)
    calc points 0.0

[<EntryPoint>]
let main argv =
    let points = Console.ReadLine() |> int
    let list = 
        Seq.initInfinite (fun _ -> Console.ReadLine())
        |> Seq.takeWhile(String.IsNullOrEmpty >> not)
        |> Seq.map (fun o -> o.Split [|' '|] |> Array.map (float)) 
        |> Seq.toArray
        |> Array.map (fun item -> { X = item.[0]; Y = item.[1] })
        |> Array.toList
    let perimeter = calcPolygonPerimeter list
    printfn ("%f") perimeter
    0