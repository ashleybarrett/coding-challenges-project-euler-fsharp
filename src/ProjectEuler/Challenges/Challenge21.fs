module Challenge21

//open ProjectEuler.Helpers.Math

let solution = 
    //https://projecteuler.net/problem=21

    let upperBound = 10000
    let getDivisors number = [1..(number - 1)] |> Seq.filter (fun x -> number % x = 0) 
    let getSumOfDivisors n = n |> getDivisors |> Seq.sum

    [|1..upperBound|]
    |> Array.sumBy(fun number -> 
        let left = getSumOfDivisors number
        let right =  getSumOfDivisors left
        
        match number = right && left <> right with
        | true -> number
        | _ -> 0
    )

    

    