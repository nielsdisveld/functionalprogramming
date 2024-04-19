module List



// List
type List =
    | Empty
    | Node of int * List

    member this.Add(x) = Node(x, this)

let lst0: List = Empty.Add(1).Add(2)
let lst = Node(3, Node(2, Empty))
let lst2 = Node(5, lst)
let inline (@) x l = Node(x, l)
2 @ Empty
// Contains
let rec contains x lst =
    match lst with
    | Empty -> false
    | Node(y, ys) -> if y = x then true else contains x ys

contains 69 lst
// Find
let rec find p lst =

    match lst with
    | Empty -> failwith "Oof"
    | Node(y, ys) -> if p y then y else find p ys

find (fun x -> x % 2 = 0) lst
let x: int list = null
