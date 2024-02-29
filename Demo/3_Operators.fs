module Operators



// + for Tuples
let inline (+.) (x1, y1) (x2, y2) = x1 + x2, y1 + y2
let tuple1 = (2, 5)
let tuple2 = (1, 2)

// tuple1 +. tuple2



// Pipes
let inline (|>) x f = f x
// 2.4 |> round |> System.Math.Sqrt
