#include<iostream>
using namespace std;

struct Node
{
	int count;
	char str[500];
};

Node combinations[10];

int main(int argc, char const *argv[])
{
	
	combinations[0]->count = 1;
	combinations[0]->str = "abc";
	cout<<combinations[0]->count;
	cout<<combinations[0]->str;
	return 0;
}