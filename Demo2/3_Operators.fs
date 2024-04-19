module Operators



// + for Tuples
let (+.) (x1, y1) (x2, y2) = (x1 + x2, y1 + y2)
(2, 3) +. (4, 5)

// Pipe operator
let (|>) x f = f x

2 |> float |> System.Math.Sqrt
