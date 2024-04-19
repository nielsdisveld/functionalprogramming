// Option type
type Option<'a> =
    | None
    | Some of 'a

let bind f opt =
    match opt with
    | None -> None
    | Some x -> f x
// Functions
let inv x =
    match x with
    | 0. -> None
    | _ -> Some(1. / x)

let half x = x * 0.5 |> Some



// With pipes
let (>>=) i f = bind f i
let crappyMult2 i = i >>= inv >>= half >>= inv

crappyMult2 0.
