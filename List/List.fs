module List

type List<'T> =
    | Empty
    | Node of 'T * List<'T>

    member this.Add x = Node(x, this)

let rec contains x lst =
    match lst with
    | Empty -> false
    | Node(y, ys) -> if x = y then true else contains x ys
