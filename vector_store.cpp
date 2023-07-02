#include<iostream>
#include<vector>


using namespace std;

int main(int argc, char const *argv[])
{
	// Vector initialization by pushing values
	int n = 10;
	std :: vector< int > v;
	for (int i=0; i<n; i++){
		v.push_back(i);
	}

	for (int i=0; i<n; i++){
		cout << v[i] << " ";
	} 

	// Specifying size and intializing all values

	int n = 3;

	std :: vector <int> v (n, 10);

	for (int x : v){
		cout << x << " "; 
	}	// Prints 3 10s
         

	return 0;
}