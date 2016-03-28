/*
  Reverse a linked list and return pointer to the head
  The input list will have at least one element  
  Node is defined as  
  class Node {
     int data;
     Node next;
  }
*/
    // This is a "method-only" submission. 
    // You only need to complete this method. 
Node Reverse(Node head) {
    

    if(head==null){
        return head;
    }
        Node next = head;
    Node previous = null;
    Node curr = head;

    while(curr.next!=null){
        next = curr.next;
        //System.out.println(next.data);
        curr.next = previous;
        previous = curr;
        curr = next;
    }
    //head = previous;
    curr.next = previous;
    
    return curr;
}

