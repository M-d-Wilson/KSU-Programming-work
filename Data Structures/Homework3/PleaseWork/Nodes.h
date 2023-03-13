#ifndef NODE_HPP
#define NODE_HPP

#include <string>

class Node
{
	public:
		Node();
		void set_data(char newdata);
		char data() const;
		void set_next(Node* newlink);
		void set_prev(Node* newlink);
		const Node* next() const;
		Node* next();
		Node* prev();
		const Node* prev() const;

	private:
		char data_field;
		Node* next_ptr;
		Node* prev_ptr;
};

#endif
