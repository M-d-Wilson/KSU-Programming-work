#include "Node.h"

Node::Node()
{
  data_field="";
  next_ptr=NULL;
}

void Node::set_data(std::string newdata)
{
  data_field=newdata;
}

std::string Node::data() const
{
  return(data_field);
}

void Node::set_next(Node* newlink)
{
  next_ptr=newlink;
}

Node* Node::next()
{
  return next_ptr;
}

const Node* Node::next() const
{
  return next_ptr;
}
