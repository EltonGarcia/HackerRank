#if INTERACTIVE
#time "on"
#endif
let isOdd n = n % 2 <> 0
let f arr =
    let sumOdd acc n =
        match isOdd n with
        | true ->  n + acc
        | false -> acc
    List.fold sumOdd 0 arr
    
let sumFilter arr = arr |> List.filter isOdd |> List.sum