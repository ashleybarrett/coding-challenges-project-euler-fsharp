module Challenge06

let solution = 
    //https://projecteuler.net/problem=6

    let number = 100
    let numbers = seq{1..number}

    let squareOfSum numbers = 
        numbers
        |> Seq.sum
        |> (fun x -> x * x)

    let sumOfSquares numbers = numbers |> Seq.sumBy (fun x -> x * x)
    
    squareOfSum numbers - sumOfSquares numbers

    
        
