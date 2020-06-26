open System

let factorial n = 
    let rec fac n acc =
        match n <= 1 with
        | true -> acc
        | false -> fac (n-1) (n*acc)
    fac n 1

let euler x n = (x**n) / double(factorial (int n))

let expandEulerSerie value n =
    [0..n]
    |> List.map (fun i -> euler value ((double)i))
    |> List.reduce (+)

let expandEuler10Terms n:double = expandEulerSerie n 9

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine()
    let list = 
        Seq.initInfinite (fun _ -> Console.ReadLine())
        |> Seq.takeWhile(String.IsNullOrEmpty >> not)
        |> Seq.map double
        |> Seq.toList

    List.iter (printfn("%f")) (list |> List.map expandEuler10Terms)
    0