open System;

let hasRepeatedKey list =
    let rec funAux lst =
        match lst with
        | [] -> true
        | x::xs -> not (xs |> List.exists(fun o -> o = x)) && funAux xs
    funAux list

let isFunction (list: List<int * int>) =
    let keys = list |> List.map (fun (a,b) -> a)
    hasRepeatedKey keys

let readTestCase() =
    let tests = Console.ReadLine() |> int
    Seq.init tests (fun _ -> Console.ReadLine().Split [|' '|])
    |> Seq.map (fun o -> o |> Array.map (int) |> (fun a -> (a.[0], a.[1])))
    |> Seq.toList

let toYesNo result = 
    match result with
    | true -> "YES"
    | false -> "NO"

[<EntryPoint>]
let main argv =
    let testcases = Console.ReadLine() |> int
    let tests = [1..testcases] |> List.map (fun _ -> readTestCase() |> isFunction)

    List.iter (printfn("%s")) (tests |> List.map toYesNo)
    0