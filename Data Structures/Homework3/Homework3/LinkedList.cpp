#include "LinkedList.h"
#include <iostream>

LinkedList::LinkedList()
{
  ClearList();
}

LinkedList::LinkedList(LinkedList& clone)
{
  head=clone.getFront();
}

Node* LinkedList::getFront()
{
  return head;
}

void LinkedList::ClearList()
{
  head=NULL;
}

void LinkedList::addNode_Front(std::string content)
{
  if(head==NULL)
  {
    head=new Node;
    head->set_data(content);
    head->set_next(NULL);
  }
  else
  {
    Node* tmp=new Node;
    tmp->set_data(content);
    tmp->set_next(head);
    head=tmp;
  }
}

void LinkedList::addNode_End(std::string content)
{
  if(head==NULL)
  {
    //yep, this is same as addNode_Front
    head=new Node;
    head->set_data(content);
    head->set_next(NULL);
    //std::cout<<"no nodes, added one"<<std::endl;
  }
  else
  {
    //first make your new node.
    Node* newnode;
    newnode=new Node;
    newnode->set_data(content);
    newnode->set_next(NULL);
    
    Node* tmp;
    tmp=head;
    //now get a pointer to the last node
    while(tmp->next()!=NULL)
    {
      tmp=tmp->next();
      //std::cout<<"went past a node"<<std::endl;
    }

    //tmp now points to the last node in the list...so we can update that nodes next ptr 
    tmp->set_next(newnode);
  }
}

std::string LinkedList::getDataFromNode(int nodenumber)
{
  if(head==NULL)
  {
    return("Error: Nothing in list");
  }
  else
  {
    Node* tmp;
    tmp=head;
    int current_node=0;

    //now get a pointer to the last node
    while((tmp!=NULL) && (current_node!=nodenumber))
    {
      tmp=tmp->next();
      current_node++;
      //std::cout<<"went past a node"<<std::endl;
    }
    if((current_node==nodenumber) && (tmp!=NULL))
    { 
      return(tmp->data()); 
    }
    else
    {
      return("Error:  List is not that long");
    }
  }
}

bool LinkedList::removeNode(int nodenumber)
{
  if(head==NULL)
  { return false; }

  if(nodenumber==0)
  {
    //cleanup
    Node* cleanup=head;
    head=head->next();
    delete cleanup;
    return true;
  }
  Node* tmp;
  tmp=head;
  int current_node=0;
  //We need to stop one node before the one to be deleted.
  while((tmp->next()!=NULL) && (current_node!=nodenumber-1))
  {
      tmp=tmp->next();
      current_node++;
      //std::cout<<"went past a node"<<std::endl;
  }
  if((tmp->next()!=NULL) && (current_node==nodenumber-1))
  {
    Node* cleanup=tmp->next();
    tmp->set_next(tmp->next()->next());
    delete cleanup;
    return true;
  }
  else
  { return false; }
}

size_t LinkedList::length() const
{
  if(head==NULL)
  { return 0; }

  size_t size=0;
  Node* tmp=head;
  while(tmp!=NULL)
  {
    tmp=tmp->next();
    size++;
  }
  return(size);
}
  
  
void LinkedList::printList() const
{
  Node* tmp=head;
  while(tmp!=NULL)
  {
    std::cout<<tmp->data()<<std::endl;
    tmp=tmp->next();
  }
  
}