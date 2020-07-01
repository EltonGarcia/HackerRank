open System

let integral f left right =
    let dx = 0.001
    Seq.sum [ for x in left .. dx .. right -> (f x) * dx ]

let polynomialExpr aSeq bSeq x =
    Seq.zip aSeq bSeq
    |> Seq.sumBy (fun (a, b) -> a * (x ** b))

let area aSeq bSeq left right =
    integral (polynomialExpr aSeq bSeq) left right

let rotate f x =
    let y = f x
    y * y * Math.PI

let volume aSeq bSeq left right =
    integral (rotate <| polynomialExpr aSeq bSeq) left right

let mapFloatArray (text: string) = 
    text.Split [|' '|] 
    |> Array.map (double) 
    |> Array.toList

[<EntryPoint>]
let main argv =     
    let a = Console.ReadLine() |> mapFloatArray
    let b = Console.ReadLine() |> mapFloatArray
    let lr = Console.ReadLine() |> mapFloatArray
    let l = lr.[0]
    let r = lr.[1]

    printfn("%f") (area a b l r)
    printfn("%f") (volume a b l r)
    0