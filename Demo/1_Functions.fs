module Functions



// Binding
// let add = fun (x, y) -> x + y
// let add (x, y) = x + y

let add x y = x + y
// add 3. 4.

// Currying
let add2 y = add 2 y
// add2 5



// Recursive
let rec fac n =
    match n with
    | 0u
    | 1u -> 1u
    | _ -> n * fac (n - 1u)
// fac 3u



// Higher-Order Functions
let compareBy f x y = (f x) >= (f y)
// compareBy (fun x -> -x) 2 3



// Polymorphism by default
let flip (x, y) = (y, x)
let flipped = flip ([ 2 ], [| 'A' |])
