module Challenge15

let solution = 
    //https://projecteuler.net/problem=15
    
    //This is a combination problem http://mathworld.wolfram.com/Combination.html

    let gridSize = 20I;

    let getFactorial (number: bigint) = 
        {1I..number}
        |> Seq.rev
        |> Seq.reduce (*)

    let nFactorial = getFactorial (gridSize * 2I)
    let kFactorial = getFactorial gridSize

    nFactorial / (kFactorial * kFactorial)
