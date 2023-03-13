#ifndef NODE_HPP
#define NODE_HPP

#include <string>

class Node
{
  public:
    Node();
    void set_data(std::string newdata);
    std::string data() const;

    void set_next(Node* newlink);

    const Node* next() const;
    Node* next();

  private:
    std::string data_field;
    Node* next_ptr;
};

#endif
