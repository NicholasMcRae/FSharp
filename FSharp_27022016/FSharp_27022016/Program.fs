(*
    Feb. 27 / 2016
    First F# program
*)

open System

[<EntryPoint>]
let main argv = 
    
    let sign num =
       if num > 0 then "positive"
       elif num < 0 then "negative"
       else "zero"

    Console.WriteLine(sign 10)

    0 // return an integer exit code
