module Challenge23

let solution = 
    
    //https://projecteuler.net/problem=23

    let lower = 12
    let upper = 28123

    let getSqrt (number:int) = number |> double |> System.Math.Sqrt |> int

    let isAbundant number = 
        [1..getSqrt(number)] 
        |> Seq.filter (fun x -> number % x = 0)
        |> Seq.collect (fun x -> [x; number/x])
        |> Seq.filter (fun x -> x <> number)
        |> Seq.distinct
        |> Seq.sum > number

    let getAbundantNumbers = [lower..upper] |> List.filter isAbundant

    let abundantNumbersSums =
       getAbundantNumbers
       |> List.collect (fun n -> getAbundantNumbers |> List.map (fun m -> n + m))
       |> List.filter (fun n -> n <= upper)
       |> List.distinct
       |> List.sum
 
    ([1..upper] |> List.sum) - abundantNumbersSums



    

    

    