module Challenge25

let solution = 
    
    //https://projecteuler.net/problem=22

    (1,0I,1I)
    |> Seq.unfold(fun (count, acc, ele) -> 
        let next = acc + ele
        Some((count, ele, next), (count + 1, ele, next))
    )
    |> Seq.takeWhile(fun (_, acc, _) -> acc.ToString().Length < 1000)
    |> Seq.last
    |> (fun (count, _, _) -> count + 1)
    