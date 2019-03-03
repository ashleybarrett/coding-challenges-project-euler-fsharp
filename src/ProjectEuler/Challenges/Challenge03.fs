module Challenge03
open System

let solution = 
    //https://projecteuler.net/problem=3

    let number = 600851475143L

    let getSqrt number = number |> double |> Math.Sqrt |> int64

    let isFactor number candiate = number % candiate = 0L

    let isPrime number = 
        { 2L .. (getSqrt number) }
        |> Seq.forall(fun x -> number % x <> 0L)

    { 3L .. 2L .. (getSqrt number) }
    |> Seq.filter(fun x -> isFactor number x)
    |> Seq.filter isPrime
    |> Seq.max