# Chapter 1 

[Chapter 1 - The Rust Lang Book](https://doc.rust-lang.org/stable/book/ch01-00-getting-started.html)

Intallation and hello world in Rust.

Used WSL to install rust, using VS Code to run the programs.

1. Made a main.rs file with main function to run an output. 
2. Ran it using terminal `rustc main.rs` to compile first which gave a `main` executable. Which was run by ` ./main` to get the output.
3. Made a package called `hello_world` using `cargo new hello_world` command. This gives us `src`, `Cargo.toml` (similar to `package.json` in JS) folders. 
4. On building using command `cargo run main.rs` inside the folder `Hello World!` was printed. 
5. Rust has more `cargo` commands using `cargo --help`.
6. One important command is `rust check` to debug without creating the executables.