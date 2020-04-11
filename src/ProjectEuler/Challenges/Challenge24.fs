module Challenge24

let solution = 
    
    //https://projecteuler.net/problem=24

    //https://www.geeksforgeeks.org/lexicographic-permutations-of-string/

    //let numbers = [0; 1; 2]
    let numbers = [0; 1; 2; 3; 4; 5; 6; 7; 8; 9]
    let nthPermutation = 1000000
    
    let findIndex (numbers: int list) (c: int) = List.findIndex (fun e -> e = c) numbers

    let rec tryFindNextNumber (currentIndex: int) (numbers: int list) = 
        (*let workingNumbers = 
            if (List.length numbers - 1) = currentIndex then List.rev numbers else numbers*)

        let nextIndex = currentIndex - 1

        match numbers with
        | first::second::tail -> 
            if second < first then
                Some(nextIndex, second)
            else tryFindNextNumber nextIndex <| second::tail
        | _ -> None

    let findNextToRight (nextNumber: int) (remainingNumbers: int list) (completeNumbers: int list) = 
        remainingNumbers
        |> List.filter(fun number -> number > nextNumber)
        |> List.min
        |> findIndex completeNumbers

    let swapItems (indexA: int) (indexB: int) (numbers: int list) =
        numbers 
        |> List.mapi (fun i v ->
            match i with
            | _ when i = indexA -> numbers.[indexB]
            | _ when i = indexB -> numbers.[indexA]
            | _ -> v)

    let rec getNthPermutation (nthPermutation: int) (numberOfPermutations: int) (numbers: int list) =
        match tryFindNextNumber (List.length numbers - 1) <| List.rev numbers with
        | Some(index, next) -> 
            let remaining = numbers.[(index+1)..]
            let a = findNextToRight next remaining numbers

            let swappedItems = swapItems index a numbers

            let head = swappedItems.[0..index]
            let remainingSorted = List.sort swappedItems.[(index + 1)..]
            let append = List.append head remainingSorted
            let l = numberOfPermutations + 1

            if(l = 1000000) then 
                printfn "%A" append
                append 
                |> List.map string
                |> List.reduce (+)
            else 
                //printfn "%A" append
                getNthPermutation nthPermutation l append

        | _ -> ""

    getNthPermutation nthPermutation 1 numbers



    

    

    