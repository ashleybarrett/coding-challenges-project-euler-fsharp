module Challenge09

open System

let solution = 
    //https://projecteuler.net/problem=10

    let number = 1999999L

    let getSqrt number = number |> double |> Math.Sqrt |> int64

    let isPrime number = 
        { 2L .. (getSqrt number) }
        |> Seq.forall(fun x -> number % x <> 0L)

    {3L..2L..number}
    |> Seq.filter isPrime
    |> Seq.sum
    |> (fun x -> x + 2L)

    
        
