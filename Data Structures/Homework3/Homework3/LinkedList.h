#ifndef LINKEDLIST_HPP
#define LINKEDLIST_HPP

#include "Node.h"

class LinkedList
{
  public:
  LinkedList();
  LinkedList(LinkedList& clone);
  Node* getFront();

  void addNode_Front(std::string content);
  void addNode_End(std::string content);
  size_t length() const;
  void printList() const;
  std::string getDataFromNode(int nodenumber);
  bool removeNode(int nodenumber);



  private:
  Node* head;
  void ClearList();
};

#endif