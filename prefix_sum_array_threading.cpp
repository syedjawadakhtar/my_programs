/*
Question: Write a paralle program to compute the prefix sum of an array
Solution: This program uses threads to compute the prefix sum of an array of any size.
The maximum size of the threads is 4 as it is the total number of processors on the computer 
used for processing parallely.

***Example Output***

Enter size of the array: 4
arr = [3 6 7 5 ]

Prefix sum matrix is
[3 9 16 21 ]

****End of Output***


Command to compile the program on linux platform: ```g++ -pthread matrix_multiplication_threading.cpp```

Source of learning pthreads: geeksforgeeks.org

*/


#include<iostream>
#include<pthread.h>
#include<stdlib.h> // rand()

using namespace std; 

//Maximum size of matrix 
#define MAX_SIZE 500 

//Maximum number of threads; As having 4 processors  
#define MAX_THREAD 4

int arr[MAX_SIZE]; 
int prefixSum[MAX_SIZE]={0};
int step_i = 0; //Counter
int size;	//Size of the array

void* prefix(void* arg) 
{ 
	int core = step_i++; 

	// Each thread computes 1/4th of array
	for (int i = core * size / 4; i < (core + 1) * size / 4; i++) 
		for (int j = i; j >= 0; j--) 
				prefixSum[i] += arr[j];

	//pthread_exit(NULL);			 
} 

// Function printing array
void print(int C[], int m){
	for (int i = 0; i < m; ++i)
	{
		if (i == 0){
			cout<<"[";
		}
		cout<<C[i]<<" ";

		if (i == m-1){
			cout<<"]"<<endl;
		}	
	}
}

// Driver Code 
int main() 
{ 	
	cout<<"Enter size of the array: ";
	cin>>size;


	//Random generation of values for the array
	for (int i=0; i < size; i++ ){
		arr[i] = rand() % 10;
	} 
	
	// Printing the values of the array
	cout<<"arr = ";
	print(arr, size);

	// Declaring threads 
	pthread_t threads[MAX_THREAD]; 

	// Creating threads, each evaluating its own part 
	for (int i = 0; i < MAX_THREAD; i++) { 
		int* p; 
		pthread_create(&threads[i], NULL, prefix, (void*)(p));

		// // Printing the matrix after each thread computation
		// cout<<endl<<"Thread "<<i+1<<" completed"<<endl;
		// print(prefixSum, size) ;
 
	} 

	// Joining and waiting for all threads to complete 
	for (int i = 0; i < MAX_THREAD; i++){ 
		pthread_join(threads[i], NULL);
	} 	 

	// Displaying the result matrix 
	cout << endl<< "Prefix sum matrix is" << endl; 
	print(prefixSum, size) ;

	return 0; 
} 