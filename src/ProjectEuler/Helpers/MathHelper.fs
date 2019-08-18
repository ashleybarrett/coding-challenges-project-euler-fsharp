module MathHelper

    open System

    let getSqrtInt64 (number:int64) = number |> double |> Math.Sqrt |> int64