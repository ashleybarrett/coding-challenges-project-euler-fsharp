module Challenge14

let solution = 
    //https://projecteuler.net/problem=14

    let number = 999999L

    let isEven number = number % 2L = 0L

    let evenCalc number = number / 2L

    let oddCalc number = (number * 3L) + 1L

    {1L..number}
    |> Seq.map(fun x ->
        (x, x, 1)
        |> Seq.unfold(fun (originalNumber, nextNumber, chainLength) -> 
                let next = 
                        match isEven nextNumber with
                        | true -> evenCalc nextNumber
                        | false -> oddCalc nextNumber
        
                Some((originalNumber, nextNumber, chainLength), (originalNumber, next, chainLength + 1))
        )
        |> Seq.find(fun (_, nextNumber, _) -> nextNumber = 1L)
    )
    |> Seq.maxBy(fun (_, _, chainLength) -> chainLength)
    |> fun (originalNumber, _, _) -> originalNumber
    |> int
      
    


    
        
