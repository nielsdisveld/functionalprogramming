module List



// List
type List =
    | Empty
    | Node of int * List

let inline (@) x xs = Node(x, xs)
let lst = 2 @ (3 @ (4 @ Empty))

// let lst = Node(1, Node(3, Node(6, Empty)))
let lst2 = [ 1; 2; 4; 6 ]



// Contains
let rec contains x lst =
    match lst with
    | Empty -> false
    | Node(y, ys) -> if x = y then true else contains x ys

// contains 2 lst



// Find
let rec find p lst =
    match lst with
    | Empty -> failwith "Oof"
    | Node(y, ys) -> if p y then y else find p ys

// find (fun x -> x % 2 = 0) lst
