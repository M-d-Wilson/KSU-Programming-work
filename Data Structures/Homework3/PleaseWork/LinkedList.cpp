#include "LinkedList.h"
#include <iostream>

LinkedList::LinkedList()
{
	ClearList();
}

LinkedList::LinkedList(LinkedList& clone)
{
	head = clone.getFront();
	tail = clone.getTail();
}

Node* LinkedList::getFront()
{
	return head;
}

Node* LinkedList::getTail()
{
	return tail;
}

void LinkedList::ClearList()
{
	head = NULL;
}

void LinkedList::addNode_Front(char content)
{
	if(head == NULL)
	{
		head = new Node;
		head -> set_data(content);
		head -> set_next(NULL);
		tail = head;
		tail -> set_prev(NULL);
	}
	else
	{
		Node* tmp = new Node;
		tmp -> set_data(content);
		tmp -> set_prev(NULL);
		tmp -> set_next(head);
		head -> set_prev(tmp); 
		head = tmp;
	}
}

void LinkedList::addNode_End(char content)
{
	if(head == NULL)
	{
		head = new Node;
		head -> set_data(content);
		head -> set_next(NULL);
		head -> set_prev(NULL);
		tail = head;
	}
	else
	{
		Node* tmp = new Node;
		tmp -> set_data(content);
		tmp -> set_next(NULL);
		tmp -> set_prev(tail);
		tail -> set_next(tmp);
		tail = tmp;
	}
}

char LinkedList::getDataFromNode(int nodenumber)
{
	if(head == NULL)
	{
		std::cout << "Head not assigned" << std::endl;
		return ' ';
	}
	else
	{
		Node* tmp;
		tmp = head;
		int current_node = 0;

		//now get a pointer to the last node
		while((tmp!=NULL) && (current_node!=nodenumber))
		{
			tmp = tmp -> next();
			current_node++;
			//std::cout<<"went past a node"<<std::endl;
		}
		
		if((current_node == nodenumber) && (tmp != NULL))
		{ 
			return(tmp -> data()); 
		}
		else
		{
			std::cout << "Node " << nodenumber << " not assigned" << std::endl;
			return ' ';
		}
	}
}

bool LinkedList::removeNode(int nodenumber)
{
	if(head == NULL)
	{ 
		return false; 
	}

	if(nodenumber == 0)
	{
		Node* cleanup = head;
		if (head -> next() != NULL)
		{
			head -> next() -> set_prev(NULL);
		}
		head = head -> next();
		delete cleanup;
		return true;
	}
	Node* tmp;
	tmp = head;
	int current_node = 0;
	
	while((tmp->next() != NULL) && (current_node != nodenumber - 1))
	{
		tmp = tmp -> next();
		current_node++;
	}
	
	if((tmp -> next() != NULL) && (current_node == nodenumber - 1))
	{
		if(tmp == tail -> prev())
		{
			Node* cleanup = tmp -> next();
			tmp -> set_next(tmp -> next() -> next());
			tmp -> next() -> next() -> set_prev(tmp);
			tail = tmp;
			delete cleanup;
			return true;
		} 
		else
		{
			Node* cleanup = tmp -> next();
			tmp -> set_next(tmp -> next() -> next());
			tmp -> next() -> next() -> set_prev(tmp);
			delete cleanup;
			return true;
		}
	}
	else
	{ 
		return false; 
	}
}

size_t LinkedList::length() const
{
	if(head == NULL)
	{ 
		return 0; 
	}
	size_t size = 0;
	Node* tmp = head;

	while(tmp != NULL)
	{
		tmp = tmp -> next();
		size++;
	}
	return(size);
}

void LinkedList::printList() const
{
	Node* tmp = head;

	while(tmp != NULL)
	{
		std::cout << tmp -> data() << std::endl;
		tmp = tmp -> next();
	}
}
