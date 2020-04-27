/* 

Q. Write a parallel program to multiply two mxn matrices 
Solution: This program multiplies two matrices  of size 4x4 using pthread.h for 
computing the multiplication of each row parallely. 

***Example Output***

Enter the value of m and n: 4 4

Matrix A
3 6 7 5 
3 5 6 2 
9 1 2 7 
0 9 3 6 

Matrix B
0 6 2 6 
1 8 7 9 
2 0 2 3 
7 5 9 2 

Thread 1 completed
55 91 107 103 
0 0 0 0 
0 0 0 0 
0 0 0 0 

Thread 2 completed
55 91 107 103 
31 68 71 85  
0 0 0 0 
0 0 0 0 

Thread 3 completed
55 91 107 103 
31 68 71 85 
54 97 92 83 
0 0 0 0 

Thread 4 completed
55 91 107 103 
31 68 71 85 
54 97 92 83 
57 102 123 102 

Multiplication of A and B
55 91 107 103 
31 68 71 85 
54 97 92 83 
57 102 123 102 

***End of output***


Command to compile the program on linux platform: ```g++ -pthread matrix_multiplication_threading.cpp```

Source of learning pthreads: geeksforgeeks.org

*/

#include <iostream>
#include<pthread.h>
#include<stdlib.h> // rand()

using namespace std; 

// maximum size of matrix 
#define MAX_SIZE 500 

// maximum number of threads 
#define MAX_THREAD 4 

#define MAX 4

int A[MAX_SIZE][MAX_SIZE]; // Matrix A
int B[MAX_SIZE][MAX_SIZE]; // Matrix B
int C[MAX_SIZE][MAX_SIZE];  // Resultant matrix C
int step_i = 0; //Counter
int m,n = 0; // row and colum size


void* multiply(void* arg) 
{ 
	int core = step_i++; 

	// Each thread computes 1/4th of matrix multiplication 
	for (int i = core * MAX / 4; i < (core + 1) * MAX / 4; i++) 
		for (int j = 0; j < MAX; j++) 
			for (int k = 0; k < MAX; k++) 
				C[i][j] += A[i][k] * B[k][j];

	//pthread_exit(NULL);			 
} 

// Driver Code 
int main() 
{ 	
	cout<<"Enter the value of m and n: ";
	cin>>m>>n;


	// Generating random values in matrix A and matrix B 
	for (int i = 0; i < m; i++) { 
		for (int j = 0; j < n; j++) { 
			A[i][j] = rand() % 10;  
		} 
	} 

	for (int i = 0; i < n; i++) { 
		for (int j = 0; j < m; j++) { 
			B[i][j] = rand() % 10;  
		} 
	} 


	// Displaying matrix A 
	cout << endl 
		<< "Matrix A" << endl; 
	for (int i = 0; i < m; i++) { 
		for (int j = 0; j < n; j++) 
			cout << A[i][j] << " "; 
		cout << endl; 
	} 

	// Displaying matrix B 
	cout << endl 
		<< "Matrix B" << endl; 
	for (int i = 0; i < n; i++) { 
		for (int j = 0; j < m; j++) 
			cout << B[i][j] << " ";		 
		cout << endl; 
	} 



	// Declaring 4 threads 
	pthread_t threads[MAX_THREAD]; 

	// Creating four threads, each evaluating its own part 
	for (int i = 0; i < MAX_THREAD; i++) { 
		int* p; 
		pthread_create(&threads[i], NULL, multiply, (void*)(p));

		// Printing the matrix after each thread computation
		cout<<endl<<"Thread "<<i+1<<" completed"<<endl;
		for (int i = 0; i < m; i++) { 
			for (int j = 0; j < n; j++) 
				cout << C[i][j] << " ";		 
			cout << endl; 
		}
 
	} 

	// Joining and waiting for all threads to complete 
	for (int i = 0; i < MAX_THREAD; i++){ 
		pthread_join(threads[i], NULL);
	} 	 

	// Displaying the result matrix 
	cout << endl<< "Multiplication of A and B" << endl; 
	for (int i = 0; i < MAX; i++) { 
		for (int j = 0; j < MAX; j++) 
			cout << C[i][j] << " ";		 
		cout << endl; 
	} 
	return 0; 
} 
