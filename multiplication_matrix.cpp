#include <iostream>
//#include <stdio.h>
//#include<pthreads.h>

using namespace std;

int const size = 500;
int A[size][size];
int B[size][size];
int C[size][size];


void *multiplication_thread(void *){

	for (int i = 0; i < m; ++i)
	{
		for (int j = 0; j < p; ++j)
		{
			for (int k = 0; k < n; ++k)
			{
				C[i][j] = C[i][j] + A[i][k] * B[k][j];
			}
		}
	}
}

void print(int C[size][size], int m, int p){
	for (int i = 0; i < m; ++i)
	{
		for (int j = 0; j < p; ++j)
		{
			cout<<"C["<<i+1<<"]["<<j+1<<"]"<<"\n";
		}
	}
}
int main(int argc, char const *argv[])
{
	pthread_t thread_id[];	//Thread declaration
	int m=0;	//no. of rows of matrix A
	int n =0;	//no. of columns of matrix A
	int q =0;	//no. of rows of matrix 
	int p = 0;	//no. of rows of matrix A
	cout<<"Enter the no. of rows & columns of matrix A: ";
	cout<<"test";
	cin>>m>>n;
	cout<<"Enter the the no. of rows & columns of matrix B: ";
	cin>>q>>p;
	if(n==q){
		cout<<"Enter the elements of matrix A:\n";
		for(int i=0; i<m; i++){
			for (int j = 0; j < n; ++j)
			{
				cout<<"Enter element A["<<i+1<<"]["<<j+1<<"]: ";
				cin>>A[i][j];
			}
		}
		cout<<"Enter the elements of matrix B:\n";
		for(int i=0; i<m; i++){
			for (int j = 0; j < n; ++j)
			{
				cout<<"Enter element B["<<i+1<<"]["<<j+1<<"]: ";
				cin>>B[i][j];
			}
		}
		multiplication(A,B,m,n,q,p);
		print(C,m,p);

	}

	return 0;
}