module Challenge07

open System

let solution = 
    //https://projecteuler.net/problem=7

    let nthPrime = 10001

    let getSqrt number = number |> double |> Math.Sqrt |> int

    let isPrime number = {2 .. (getSqrt number) } |> Seq.forall(fun x -> number % x <> 0)

    Seq.initInfinite(fun x -> x + 2)
    |> Seq.filter isPrime
    |> Seq.item nthPrime


    
        
