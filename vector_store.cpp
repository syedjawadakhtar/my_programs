#include<iostream>
#include<vector>


using namespace std;

int main(int argc, char const *argv[])
{
	int n = 10;
	std :: vector< int > v;
	for (int i=0; i<n; i++){
		v.push_back(i);
	}

	for (int i=0; i<n; i++){
		cout << v[i] << " ";
	} 
         

	return 0;
}