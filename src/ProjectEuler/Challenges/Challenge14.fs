module Challenge14

let solution = 
    //https://projecteuler.net/problem=14

    let number = 999999L

    let isEven number = number % 2L = 0L

    let evenCalc number = number / 2L

    let oddCalc number = (number * 3L) + 1L

    {1L..number}
    |> Seq.map(fun x ->
        (x, 1)
        |> Seq.unfold(fun (number, chainLength) -> 
                let next = 
                        match isEven number with
                        | true -> evenCalc number
                        | false -> oddCalc number
        
                Some((number, chainLength), (next, chainLength + 1))
        )
        |> Seq.find(fun (number, _) -> number = 1L)
        |> fun (_, chainLength) -> (x, chainLength)
    )
    |> Seq.maxBy(fun (_, chainLength) -> chainLength)
    |> fst
    |> int
      
    


    
        
