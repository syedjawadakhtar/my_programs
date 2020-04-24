/* Given an array arr[] of size n, its prefix sum array is another array prefixSum[]
 of same size such that the value of prefixSum[i] is arr[0] + arr[1] + arr[2] … arr[i]. */

#include<iostream>
#include<stdlib.h>	//For rand()

using namespace std;

int const size = 500;

void print(int C[size], int m){
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

int main(int argc, char const *argv[])
{
	int arr[size], prefixSum[size]={0};
	int n;

	cout <<"Enter the size of array: ";
	cin>>n;

	//Random generation of values for the array
	for (int i=0; i < n; i++ ){
		arr[i] = rand() % 100;
	}

	cout<<"arr = ";
	print(arr, n);

	//Setting up the prefixSum array
	for (int i=0; i < n; i++ ){
		for (int j = i; j >= 0; j--){
			prefixSum[i] += arr[j]; 
		}
	}

	cout<<"prefixSum = ";
	print(prefixSum, n);

	return 0;
}