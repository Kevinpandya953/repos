//inserting a number in a sorted list 
#include<iostream>
#include<stdlib.h>
# define NULL 0
using namespace std;
class linked_list {
public:
	int number;
	struct linked_list* next;
};
typedef class linked_list node;
int main()
{
	int n;
	node* head = NULL;
	void print(node * p);
	node* insert_Sort(node * p, int n);
	std::cout << "Input the list of numbers: \n"
			  << " At the end type -999 to terminate input...";
	std::cin >> n;
	while (n != -999)
	{
		if (head == NULL)
		{
			head = (node*)malloc(sizeof(node));
			head->number = n;
			head->next = NULL;
		}
		else {
			head = insert_Sort(head, n);
		}
		std::cin >> n;
	}
	std::cout << "\n"
		<< (head)
		<< "\n";
}
node* insert_Sort(node* list, int x)
{
	node* p1, * p2, * p;
	p1 = NULL;
	p2 = list;
	for (p2 = 0; p2->number < x; p2 = p2->next)
	{
		p1 = p2;
		if (p2->next == NULL) {
			p2 = p2->next;
			break;
		}

	}

}
