module Challenge07

open ProjectEuler.Helpers.Math

let solution = 
    //https://projecteuler.net/problem=7

    let nthPrime = 10001

    Seq.initInfinite(fun x -> x + 2)
    |> Seq.filter isPrime
    |> Seq.item nthPrime


    
        
