#include<iostream>
#include<vector>
#include<random>

using namespace std;

int main(int argc, char const *argv[])
{
	int n = 10;
	vector <int> v;
	for (int i=0; i<n; i++){
		v.push_back(n);
	}

	for (int i = 0; i != v.size(); i++){
		cout<<i;
	}	

	return 0;
}