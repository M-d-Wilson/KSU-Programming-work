#include "Nodes.h"

Node::Node()
{
	data_field = ' ';
	next_ptr = NULL;
	prev_ptr = NULL;
}

void Node::set_data(char newdata)
{
	data_field = newdata;
}

char Node::data() const
{
	return(data_field);
}

void Node::set_next(Node* newlink)
{
	next_ptr = newlink;
}

void Node::set_prev(Node* newlink)
{
	prev_ptr = newlink;
}

Node* Node::next()
{
	return next_ptr;
}

const Node* Node::next() const
{
	return next_ptr;
}

Node* Node::prev()
{
	return prev_ptr;
}

const Node* Node::prev() const
{
	return prev_ptr;
}