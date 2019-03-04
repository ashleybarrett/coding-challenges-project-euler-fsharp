module Challenge05

let solution = 
    //https://projecteuler.net/problem=5

    let maxNumber = 20

    let isMultiples maxNumber candiate =
        {1..maxNumber}
        |> Seq.forall(fun x -> candiate % x = 0)


    Seq.initInfinite(fun x -> x + maxNumber)
    |> Seq.filter(fun x -> isMultiples maxNumber x)
    |> Seq.head
        
