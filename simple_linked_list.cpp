#include<iostream>

using namespace std;

struct Node
{
	int data;
	Node *next;	
};

Node *head = NULL;

void linkedlist(int info){
	Node *new_node = new Node; 	 
	new_node->data=info;
	new_node->next = head;
	head = new_node; 
}

void displaying_linked_list(){
	Node *ptr = NULL;
	ptr = head;
	while(ptr!=NULL){
		cout<<ptr->data;
		ptr = ptr->next;
	}
}

int main(int argc, char const *argv[])
{
	int n;
	linkedlist(1);
	linkedlist(10);
	linkedlist(15);
	displaying_linked_list();

	return 0;
}