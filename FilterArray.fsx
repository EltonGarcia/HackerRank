(*
Link: https://www.hackerrank.com/challenges/fp-filter-array/problem

- Problem:
Filter a given array of integers and output only those values that are less than a specified value . 
The output integers should be in the same sequence as they were in the input. 
The purpose of this challenge is to learn how to write your own implementation of a filter function. We recommend not using the inbuilt library function.

- Sample Input: 3, 1, 0, 9, 8, 2, 7, 5, 1, 3, 0
- Sample Output: 2, 1, 0

- Explanation: 2, 1 and 0 are the list elements that are less than the X delimiter, 3. They are displayed in the same order as they were in the original list.
*)
open System

let rec filter (list: List<int>, n: int, result: List<int>) = 
    match list with
    | [] -> result |> List.rev
    | y::ys -> 
        if (y < n) 
        then filter (ys, n, y::result) 
        else filter (ys, n, result)

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int;
    let list = 
        Seq.initInfinite (fun _ -> Console.ReadLine())
        |> Seq.takeWhile(String.IsNullOrEmpty >> not)
        |> Seq.map System.Int32.Parse
        |> Seq.toList

    List.iter (printfn("%d")) (filter (list, n, []))
    0