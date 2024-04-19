module Functions



// Binding
let f = fun (x, y) -> x + y
let add (x, y) = x + y
let add' x y = x + y




// Currying
let add5 x = add' 5


// Recursive
let rec fac n =
    match n with
    | 0u
    | 1u -> 1u
    | _ -> n * fac (n - 1u)

fac 261739
// Higher-Order Functions
let compareBy f x y = f x >= f y


// Polymorphism by default
let flip (x, y) = (y, x)
