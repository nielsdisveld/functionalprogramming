module Option



type Option<'T> =
    | None
    | Some of 'T

let bind f opt =
    match opt with
    | None -> None
    | Some x -> f x

let inline (>>=) opt f = bind f opt



// Functions
let inv x =
    match x with
    | 0. -> None
    | _ -> Some(1. / x)

let half x = Some(x * 0.5)

// let crappyMultiplyBy2 i = inv (half (inv i))



// With pipes
let crappyMultiplyBy2 i =
    i
    >>= inv
    >>= half // comment
    >>= inv
