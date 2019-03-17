module Challenge12

open System

let solution = 
    //https://projecteuler.net/problem=12

    let greaterThanNumberOfDivisors = 500

    let getSqrt number = number |> double |> Math.Sqrt |> int64

    let getNumberOfDivisors number = 
        let upperBound = getSqrt number
        [1L..upperBound] 
        |> Seq.filter (fun x -> number % x = 0L) 
        |> Seq.collect (fun x -> [x; number / x])
        |> Seq.length

    (0L, 1L)
    |> Seq.unfold(fun (acc, next) -> Some((acc, next), (acc + next, next + 1L)))
    |> Seq.find(fun (acc, _) -> getNumberOfDivisors acc  > greaterThanNumberOfDivisors)
    |> (fun (acc, _) -> acc)




    
        
