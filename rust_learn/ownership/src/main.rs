fn main() {
    // --------- ownership rules ------------
    // 1. Each value in Rust has variable that's called its owner.
    // 2. There can only be one owner at a time.
    // 3. When the owner goes out of scope, the value will be dropped.

    {   // This point s is not valid and can't be used as not yet declared.
        let s = String::from("hellow");   // decalring a dynamic string; now saved on heap by allocating memory automatically
        // statements with s 
    }   // this ends the scope of s, s is no longer valid. rust drops the value means deallocates the value. 
        // In C++ we have to use new to allocate and delete to deallocate but rust does it automatically by the end of scope.

        /* How variables interact */
        let x = 5;
        let y = x; // copy - for simple types like integers, booleans and characters stored in stack.

        let s1 = String::from("hellow"); // pointer to hellow in the heap, length of the string  capacity (actual amount of memory allocated for the string)
        // let s2 = s1; // Move and not shallow copy
        let s2 = s1.clone(); // this is copying
        println!("{}", s1);

        /* Ownership and functions */
        let s = String::from ("hellow");
        takes_ownership(s.clone()); // so using s.clone for sending as a parameter
        println!("{}", s); // can't be borrowed after it's moved; 
        // bc sending the parameter s in fn sends a copy of it to the fn, the fn prints it and then drops it after its scope ends. 
        // But this doesn't happends with i32, integers can send and received easily in fns
        // can move ownership by returning it from a function to a variable and then using it
        // Transfering ownership
        let s1 = gives_ownership();
        let s2 = String::from("hellow");
        let s3 = takes_and_gives_back(s2);
        println!("s1 = {}, s3 = {}", s1, s3);

        // References allow you to refer(ptr)[borrowing] to some value without taking ownership of it.
        // But references are immutable so you can't modify it in the function; solution: make the string mutable and mutable references. can't mix immutable and mutable references.
        let s1 = String::from("hellow");
        let len = calculate_length(&s1);
        println!("The lenght of '{}' is {},", s1, len);

        // dangling references
        // let reference_to_nothing = dangle();

        /* Slicing */
        let mut s = String::from("hellow world");
        let hello = &s[0..5];
        let world = &s[6..11];
        let a = [1,2,3,4,5];
        let slice = &a[1..3];
}

// fn dangle() -> &String {
//     let s = String::from("hello");

//     &s // This will give error on line fn dangle() -> &String to remove the &. as the value is dropped and there isn't any value to be returned; use lifetime.
// }

fn calculate_length(s: &String) -> usize {
    let length = s.len(); // len() returns the length of a string
    length
}

fn gives_ownership() -> String {
    let some_string = String::from("Hellow");
    return some_string;
}
fn takes_and_gives_back(a_string: String) -> String {
    a_string
}    

fn takes_ownership (some_string: String){
    println!("{}", some_string);
}
