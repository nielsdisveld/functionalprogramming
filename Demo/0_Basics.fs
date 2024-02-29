module Basics



// Binding
let x = 2
// x = 3
let mutable y = "dsfdsf"
y <- "asd"



// Collections
let lst = [ 2; 6; 7 ] // Linked List
let arr = [| "one"; "two"; "three" |] // Array



// Combined types
let tuple = ("entry1", 2)
let (str, num) = tuple

type Person = { Name: string; Id: int }
let person = { Name = "Test"; Id = 37 }



// Union
type RGB =
    | Red
    | Green
    | Blue

let rgb = Green

// match rgb with
// | Red -> "Red"
// | Green
// | Blue -> "Not red"

type Crazy =
    | Number of int
    | Tuple of string * char
    | Color of RGB
    | P of Person
    | Crazy of Crazy

let crazy = P person

match crazy with
| P p -> p.Id
| Number i -> i
| Color rgb -> if rgb = RGB.Red then 1 else 0
| _ -> 0
