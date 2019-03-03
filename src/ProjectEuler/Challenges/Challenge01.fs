module Challenge01

let solution = 
    //https://projecteuler.net/problem=1

    let maxNumber = 999

    {1..maxNumber}
    |> Seq.filter(fun x -> x % 3 = 0 || x % 5 = 0)
    |> Seq.sum