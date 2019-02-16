//Program to make a stack using a linked list

#include<iostream>
#include<stdlib.h>

using namespace std;

struct Node{
	int data;
	Node *pointer;
};

Node *head=NULL;
Node *base=NULL;

void push(int a){
	Node n = new Node;
	n->data = a;
	n->pointer = NULL;
	if(head == NULL){
		head = n;
		base = head;
	}
	else {
		head->pointer = n;
		head = n;
	}
}

void print(){
	Node *temp;
	while(temp !=NULL){
		cout<<base->data<<"->";
		temp = base->pointer;
	} 
	
}


int main(int argc, char const *argv[])
{
	int data;
	cout<<"_______________________MENU____________________";
	cout<<"1. Push into the stack\n2. Print the stack\n3. Pop from the stack\n";
	int choice;
	cout<<"Enter the choice: ";
	cin>>choice;
	switch(ch){
		case 1 : cout<<"ENter the element data: ";
				 cin>>data;
				 push(data);
				 break;
		case 2 : print();
				 break;
		default : cout<<"Please enter a valid value";
				  exit();
	}
	return 0;
}