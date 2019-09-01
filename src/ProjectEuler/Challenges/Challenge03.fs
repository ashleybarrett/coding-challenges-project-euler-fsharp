module Challenge03

open ProjectEuler.Helpers.Int64Math

let solution = 
    //https://projecteuler.net/problem=3

    let number = 600851475143L

    { 3L .. 2L .. (getSqrt number) }
    |> Seq.filter(fun x -> isFactor number x)
    |> Seq.filter isPrime
    |> Seq.max