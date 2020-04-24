#include<iostream>
#include<stdlib.h>

using namespace std;

int main(int argc, char const *argv[])
{
	int ar[100][100];
	int n,m;
	cout <<"No. of rows and columns: ";
	cin>>m>>n;

	for (int i =0; i < m; i++){
		for(int j =0; j <n ; j++){
			ar[i][j] = rand() % 10;
		}
	}

	for (int i = 0; i < m; ++i)
	{
		cout << "\n";
		for (int j = 0; j < n; ++j)
		{
			cout<<ar[i][j] << " ";
		}
	}
	return 0;
}