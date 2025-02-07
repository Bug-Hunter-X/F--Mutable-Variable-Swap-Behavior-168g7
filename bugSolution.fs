let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap &x &y //Note the use of & to pass by reference
printf "%d %d" x y //This will print 20 20 as expected

//Alternatively, for immutability:

let swap2 (x, y) = (y,x)

let a = 10
let b = 20
let (a,b) = swap2 (a,b) 
printf "%d %d" a b //This will still print 10 20

//Correct approach to swap using immutability:
let (a,b) = swap2 (a,b)
printf "%d %d" a b