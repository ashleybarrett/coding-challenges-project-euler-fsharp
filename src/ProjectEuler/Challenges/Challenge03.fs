module Challenge03

open MathHelper

let solution = 
    //https://projecteuler.net/problem=3

    let number = 600851475143L

    let isFactor number candiate = number % candiate = 0L
    
    let isPrime number = 
        { 2L .. (MathHelper.getSqrtInt64 number) }
        |> Seq.forall(fun x -> number % x <> 0L)

    { 3L .. 2L .. (MathHelper.getSqrtInt64 number) }
    |> Seq.filter(fun x -> isFactor number x)
    |> Seq.filter isPrime
    |> Seq.max