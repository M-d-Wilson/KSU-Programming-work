 #ifndef LINKEDLIST_HPP
#define LINKEDLIST_HPP

#include "Nodes.h"

class LinkedList
{
	public:
	LinkedList();
	LinkedList(LinkedList& clone);
	
	Node* getFront();
	Node* getTail();
	void addNode_Front(char);
	void addNode_End(char content);
	size_t length() const;
	void printList() const;
	char getDataFromNode(int nodenumber);
	bool removeNode(int nodenumber);

	private:
	Node* head;
	Node* tail;
	
	void ClearList();
};

#endif