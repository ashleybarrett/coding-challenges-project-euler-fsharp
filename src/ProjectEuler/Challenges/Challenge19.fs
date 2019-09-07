module Challenge19

open System

let solution = 
    //https://projecteuler.net/problem=19

    (DateTime(1901, 1, 1), 0)
    |> Seq.unfold(fun (date, count) -> 
      let isSunday = if date.DayOfWeek = DayOfWeek.Sunday then 1 else 0

      Some((date, count), (date.AddMonths(1), isSunday))
    )
    |> Seq.takeWhile(fun (date, _) -> date.Year < 2001)
    |> Seq.sumBy snd