module Challenge02

let solution = 
    //https://projecteuler.net/problem=2

    let maxNumber = 4000000

    (0,1)
    |> Seq.unfold(fun (acc, ele) -> 
        let next = acc + ele
        Some((ele, next), (ele, next))
    )
    |> Seq.takeWhile(fun (acc, _) -> acc < maxNumber)
    |> Seq.filter(fun (acc, ele) -> acc % 2 = 0)
    |> Seq.sumBy fst